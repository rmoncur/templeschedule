using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempleSchedule {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		List<Ward> wards = new List<Ward>();
		List<TimeSlot> timeslots = new List<TimeSlot>();
		Queue<TimeSlot> freetimeslots = new Queue<TimeSlot>();
		List<TimeSlot> takentimeslots = new List<TimeSlot>();
		List<TimeSlot> weekendtimeslots = new List<TimeSlot>();
		List<TimeSlot> weekdaytimeslots = new List<TimeSlot>();
		List<DateTime> blackoutDates = new List<DateTime>();
		List<int> weekdayStartHours = new List<int>() {5,6,7};
		List<int> weekendStartHours = new List<int>() {7,8,9};
		Dictionary<int, List<TimeSlot>> intervalTimeSlots = new Dictionary<int,List<TimeSlot>>();
		Dictionary<int, List<TimeSlot>> weekdayIntervalTimeSlots = new Dictionary<int, List<TimeSlot>>();
		Dictionary<int, List<TimeSlot>> weekendIntervalTimeSlots = new Dictionary<int, List<TimeSlot>>();
		string outputfile;

		/// <summary>
		/// Make that schedule!
		/// </summary>
		private void makeScheduleButton_Click(object sender, EventArgs e) {

			//Read in Wards
			if( wards.Count == 0) 
			for (int i = 0; i < 9; i++) {
				for (int j = 0; j < 10; j++ )
					wards.Add(new Ward("Ward " + i, "Stake " + j));
			}

			//Read in Blackouts
			if (blackoutDates.Count == 0) {
				blackoutDates.Add(new DateTime(2014, 12, 25));
				blackoutDates.Add(new DateTime(2014, 12, 31));
				blackoutDates.Add(new DateTime(2014, 1, 1));
				blackoutDates.Add(new DateTime(2014, 7, 4));
				blackoutDates.Add(new DateTime(2014, 11, 27));
			}

			//Read in Times
			DateTime begin = new DateTime(2015, 1, 1);
			DateTime end = new DateTime(2015, 12, 31);

			//Looping through each timeperiod section and assigning wards timeslots
			for (int i = 0; i < this.numericUpDown1.Value; i++) {

				List<Ward> shuffledWards = new List<Ward>(this.wards);
				shuffledWards.Shuffle();

				foreach (Ward w in shuffledWards) {

					//Skipping if it has too many already
					if (w.timeslots.Count > this.numericUpDown1.Value)
						continue;

					this.weekendIntervalTimeSlots[i].Shuffle();
					this.weekdayIntervalTimeSlots[i].Shuffle();

					//Adding weekends first... then weekdays
					if (this.weekendIntervalTimeSlots[i].Count > 0 && w.numWeekends < this.numericUpDownWeekends.Value) {
						TimeSlot t = this.weekendIntervalTimeSlots[i][this.weekendIntervalTimeSlots[i].Count - 1];
						w.timeslots.Add(t);	//adding to the ward
						t.assignedWard = w;
						this.weekendIntervalTimeSlots[i].Remove(t);	//removing from the list
					} else if(weekdayIntervalTimeSlots[i].Count > 0) {
						TimeSlot t = this.weekdayIntervalTimeSlots[i][this.weekdayIntervalTimeSlots[i].Count - 1];
						w.timeslots.Add(t);	//adding to the ward
						t.assignedWard = w;
						this.weekdayIntervalTimeSlots[i].Remove(t);	//removing from the list
					}

				}


			}

			//Prioritizing Later Timeslots
			foreach (TimeSlot t in this.timeslots) {

				//Skipping unassigned timeslots
				if (t.assignedWard == null) continue;

				//Getting later timeslots from same day
				try {
					TimeSlot t2 = this.timeslots.Last(s =>
						s.startTime.Date == t.startTime.Date
						&& s.startTime != t.startTime
						&& s.startTime > t.startTime
						&& s.assignedWard == null
					);

					if (t2 != null) {

						t2.assignedWard = t.assignedWard;
						t2.assignedWard.timeslots.Add(t2);

						t.assignedWard.timeslots.Remove(t);
						t.assignedWard = null;

					}

				} catch (Exception ex) {
					continue;
				}

			}

			//Writing Output
			this.writeOutput();

			return;

			//TODO: Assigning Wards with less than maximum timeslots
			List<Ward> notFullWards = this.wards.FindAll(s => s.timeslots.Count < this.numericUpDown1.Value);

			foreach (Ward w in notFullWards) {

				TimeSlot maxDistanceSlot = null;
				TimeSpan maxDistanceSpan = new TimeSpan();

				foreach (TimeSlot wt in w.timeslots) {

					foreach (TimeSlot t in this.timeslots.FindAll(s => s.assignedWard == null)) {

						if (maxDistanceSlot == null) {	//If this is the first span, then it is the king automatically
							maxDistanceSlot = t;
							maxDistanceSpan = t.startTime - wt.startTime;
							continue;
						} else {

							TimeSpan tspan = t.startTime - wt.startTime;
							if (tspan.TotalHours > maxDistanceSpan.TotalHours) {	//If this span is closer
								maxDistanceSpan = tspan;
							}

						}



						//TODO: Find the largest distance

					}

				}
			}
			

		}

		/// <summary>
		/// Generating the available timeslots for the year
		/// </summary>
		/// <param name="begin"></param>
		/// <param name="end"></param>
		private void generateTimeSlots(DateTime begin, DateTime end) {

			//Refreshing the interval timeslots dictionaries
			timeslots = new List<TimeSlot>();
			freetimeslots = new Queue<TimeSlot>();
			takentimeslots = new List<TimeSlot>();
			weekendtimeslots = new List<TimeSlot>();
			weekdaytimeslots = new List<TimeSlot>();
			intervalTimeSlots = new Dictionary<int, List<TimeSlot>>();
			weekdayIntervalTimeSlots = new Dictionary<int, List<TimeSlot>>();
			weekendIntervalTimeSlots = new Dictionary<int, List<TimeSlot>>();
			
			// 1) Find all days that aren't blacked out
			List<DateTime> availableDays = new List<DateTime>();
			for (DateTime date = begin; date <= end; date = date.AddDays(1)) {
				if (date.DayOfWeek == System.DayOfWeek.Monday || date.DayOfWeek == System.DayOfWeek.Sunday || blackoutDates.Contains(date))
					continue;

				availableDays.Add(date);

			}

			// 2) Divide up available days into equal intervals
			int totalDays = availableDays.Count;
			int intervalLength = (int)(totalDays / this.numericUpDown1.Value);
			int currentSpan = 0;
			for (int i = 0; i < this.numericUpDown1.Value; i++) {	//Adding a list for each timeslot
				this.intervalTimeSlots.Add(i, new List<TimeSlot>());
				this.weekdayIntervalTimeSlots.Add(i, new List<TimeSlot>());
				this.weekendIntervalTimeSlots.Add(i, new List<TimeSlot>());
			}

			// 3) Generate Timeslots for each day

			//Looping through each date in the range
			int its = 0;
			//for (DateTime date = availableDays[0]; date <= availableDays[availableDays.Count-1]; date = date.AddDays(1), its++) {

			for (int i = 0; i < availableDays.Count; i++ ){

				DateTime date = availableDays[i];

				//Determining which span of the year the date belongs to
				if (i % intervalLength == 0 && i > 0 && i < (intervalLength * this.numericUpDown1.Value))
					currentSpan++;

				//Adding TimeSlots for weeks of the days
				if (date.DayOfWeek != System.DayOfWeek.Saturday) {

					foreach (int j in weekdayStartHours) { //Adding Weekday Slots
						TimeSlot ts = new TimeSlot(new DateTime(date.Year, date.Month, date.Day, j, 0, 0));
						timeslots.Add(ts);
						weekdaytimeslots.Add(ts);
						weekdayIntervalTimeSlots[currentSpan].Add(ts);
						intervalTimeSlots[currentSpan].Add(ts);
					}

				} else { //Adding Saturdays

					foreach (int j in weekendStartHours) { //Adding Weekend Slots
						TimeSlot ts = new TimeSlot(new DateTime(date.Year, date.Month, date.Day, j, 0, 0));
						timeslots.Add(ts);
						weekendtimeslots.Add(ts);
						weekendIntervalTimeSlots[currentSpan].Add(ts);
						intervalTimeSlots[currentSpan].Add(ts);
					}

				}

			}

			//Adding interval text to the data table
			this.listView1.Items.Clear();
			int allWeekday = 0;
			int allWeekdaysNeeded = 0;
			int allSaturdays = 0;
			int allSaturdaysNeeded = 0;
			int allDays = 0;
			int allDaysNeeded = 0;

			for (int i = 0; i < intervalTimeSlots.Count; i++) {
				ListViewItem lvi = new ListViewItem("Interval " + i);

				lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, weekdayIntervalTimeSlots[i].Count.ToString()));
				int neededWeekdays = (int)(this.numericUpDownWeekdays.Value*this.wards.Count/this.numericUpDown1.Value);
				lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, neededWeekdays.ToString() ));
				allWeekday += weekdayIntervalTimeSlots[i].Count;
				allWeekdaysNeeded += neededWeekdays;
				
				lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, weekendIntervalTimeSlots[i].Count.ToString()));
				int neededSaturdays = (int)(this.numericUpDownWeekends.Value * this.wards.Count / this.numericUpDown1.Value);
				lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, neededSaturdays.ToString() ));
				allSaturdays += weekendIntervalTimeSlots[i].Count;
				allSaturdaysNeeded += neededSaturdays;

				int neededTotal = (int)((this.numericUpDownWeekdays.Value + this.numericUpDownWeekends.Value) * this.wards.Count / this.numericUpDown1.Value);
				lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, intervalTimeSlots[i].Count.ToString()));
				lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, neededTotal.ToString()));
				allDays += intervalTimeSlots[i].Count;
				allDaysNeeded += neededTotal;
				
				listView1.Items.Add(lvi);
			}

			//All intervals
			ListViewItem tlvi = new ListViewItem("Whole Year");
			tlvi.SubItems.Add(new ListViewItem.ListViewSubItem(tlvi, allWeekday.ToString()));	//All Weekdays
			tlvi.SubItems.Add(new ListViewItem.ListViewSubItem(tlvi, allWeekdaysNeeded.ToString()));	//All Weekdays Needed
			tlvi.SubItems.Add(new ListViewItem.ListViewSubItem(tlvi, allSaturdays.ToString()));	//All Saturdays
			tlvi.SubItems.Add(new ListViewItem.ListViewSubItem(tlvi, allSaturdaysNeeded.ToString()));	//All Saturdays Needed
			tlvi.SubItems.Add(new ListViewItem.ListViewSubItem(tlvi, allDays.ToString()));	//Total
			tlvi.SubItems.Add(new ListViewItem.ListViewSubItem(tlvi, allDaysNeeded.ToString()));	//Total Needed
			listView1.Items.Add(tlvi);
		}

		/// <summary>
		/// Writing output to a CSV
		/// </summary>
		private void writeOutput() {

			this.outputfile = DateTime.Now.ToString("MM-dd-yy_HH-mm-ss") + ".csv";
			List<string> lines = new List<string>();
			lines.Add("Date,Day,Ward,Stake,Weekdays,Weekends,Total TimeSlots,Minimum Gap");
			foreach (TimeSlot t in this.timeslots) {
				string line = t.startTime.ToString() + "," + t.startTime.DayOfWeek.ToString() + ",";
				if( t.assignedWard != null)
					line += t.assignedWard.name + "," + t.assignedWard.stake + "," + t.assignedWard.numWeekdays + "," + t.assignedWard.numWeekends + "," + t.assignedWard.timeslots.Count + "," + t.assignedWard.minTimeslotSpacing;

				lines.Add(line);
			}


			System.IO.File.WriteAllLines(this.outputfile, lines);
			this.linkLabel1.Text = "Open Output File " + this.outputfile;
			this.linkLabel1.Enabled = true;

			return;
		}

		/// <summary>
		/// Opening the Output File
		/// </summary>
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(this.outputfile);
		}

		/// <summary>
		/// Refreshing the data table
		/// </summary>		
		private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
			this.Form1_Load(null,null);
		}

		/// <summary>
		/// Picking a CSV File of Wards & Stakes and Reading it In 
		/// </summary>
		private void loadWards(object sender, EventArgs e) {

			//Opeining the file dialog
			this.openFileDialog1.ShowDialog();
			string filename = this.openFileDialog1.FileName;
			
			//Opening and parsing the file
			string[] lines;
			try {
				lines = File.ReadAllLines(filename);
			} catch (Exception ex) {
				MessageBox.Show("Error Reading the Input File. Please Check the File Format and Try again.");				
				return;
			}

			this.wards.Clear();

			//Adding wards from input
			foreach (string s in lines) {
				string[] cols = s.Split(',');
				if (cols[0] == "Ward" || cols[0] == "ward") continue;

				//Adding a new ward
				wards.Add(new Ward(cols[0],cols[1]));

			}

			this.labelNumWards.Text = this.wards.Count + " Loaded";
			this.Form1_Load(null,null);
		}

		/// <summary>
		/// Reading in blackout dates
		/// </summary>		
		private void loadBlackoutDates(object sender, EventArgs e) {
			//Opeining the file dialog
			this.openFileDialog1.ShowDialog();
			string filename = this.openFileDialog1.FileName;

			//Opening and parsing the file
			string[] lines;
			try {
				lines = File.ReadAllLines(filename);
			} catch (Exception ex) {
				MessageBox.Show("Error Reading the Input File. Please Check the File Format and Try again.");
				return;
			}

			try {

				blackoutDates.Clear();
				 
				//Adding wards from input
				foreach (string s in lines) {
					string[] cols = s.Split(',');
					if (cols[0] == "Date" || cols[0] == "date") continue;

					//Adding a new blackout date
					DateTime date = Convert.ToDateTime(cols[0]);
					blackoutDates.Add(date);

				}

			} catch (Exception ex) {
				MessageBox.Show("Could not read date. Please put in format of YYYY-MM-DD (2014-05-31)");
			}

			this.labelNumBlackoutDates.Text = this.blackoutDates.Count + " Loaded";
			this.Form1_Load(null, null);
		}
	
		/// <summary>
		/// Load Function
		/// </summary>		
		private void Form1_Load(object sender, EventArgs e) {

			//Generating the timeslots
			DateTime begin = new DateTime(2015, 1, 1);
			DateTime end = new DateTime(2015, 12, 31);	
			this.generateTimeSlots(begin,end);
		}
	}
}
