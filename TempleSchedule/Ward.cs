using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleSchedule {
	class Ward {
		public string name;
		public string stake;
		public List<TimeSlot> timeslots = new List<TimeSlot>();
		public int numWeekends {
			get {
				int num = 0;
				foreach (TimeSlot t in this.timeslots)
					if (t.startTime.DayOfWeek == DayOfWeek.Saturday)
						num++;
				return num;
			}
		}

		public int numWeekdays {
			get {
				int num = 0;
				foreach (TimeSlot t in this.timeslots)
					if (t.startTime.DayOfWeek != DayOfWeek.Saturday && t.startTime.DayOfWeek != DayOfWeek.Sunday)
						num++;
				return num;
			}
		}

		//Returning the minimum distance between timeslots. This should ideally be above 30
		public double minTimeslotSpacing {
			//Sort the list
			get {
				List<TimeSlot> sorted = this.timeslots.OrderBy(x => x.startTime).ToList();

				TimeSpan smallestGap = new TimeSpan();
				for (int i = 0; i < sorted.Count - 1; i++) {
					//Computing the span
					TimeSpan currentGap = sorted[i + 1].startTime - sorted[i].startTime;

					if (i == 0) { 
						smallestGap = currentGap;
						continue;
					}

					if (currentGap < smallestGap)
						smallestGap = currentGap;
				}

				return smallestGap.TotalDays;
			}

			//Find gap intervals
			
		}

		//Constructor
		public Ward(string _name, string _stake) {
			this.name = _name;
			this.stake = _stake;

			//Giving us some default values
			if (this.name == "") {
				this.name = "Ward " + Program.random.Next(1, 8);
			}

			if (this.stake == "") {
				this.stake = "Stake " + Program.random.Next(1, 8);
			}

		}

		//Adjusting the gaps
		internal void adjustGap() {
			
			List<TimeSlot> sorted = this.timeslots.OrderBy(x => x.startTime).ToList();
			TimeSpan smallestGap = new TimeSpan();
			TimeSlot t1 = new TimeSlot(), t2 = new TimeSlot();

			//Computing the smallest gap between dates as well as finding the timeslots around it
			for (int i = 0; i < sorted.Count - 1; i++) {
				
				//Computing the span
				TimeSpan currentGap = sorted[i + 1].startTime - sorted[i].startTime;

				if (i == 0) {
					smallestGap = currentGap;
					t2 = sorted[i + 1];
					t1 = sorted[i];
					continue;
				}

				if (currentGap < smallestGap) {
					smallestGap = currentGap;
					t2 = sorted[i + 1];
					t1 = sorted[i];
				}
			}

			//Swapping until it is in the threshhold
			int loops = 0;
			int minGap = 30;
			while (true) {

				//Swap slots with another ward
				List<TimeSlot> tempList = new List<TimeSlot>(t1.sectionList);
				tempList.Shuffle();

				TimeSlot tOther = tempList.First(x => x.assignedWard != null);
				Ward tOtherWard = tOther.assignedWard;

				double t1Gap1 = this.minTimeslotSpacing;
				t1.swapWards(tOther);
				double t1Gap2 = this.minTimeslotSpacing;

				if (tOtherWard.minTimeslotSpacing > minGap && this.minTimeslotSpacing > minGap) {
					break;
				} else 
					t1.swapWards(tOther);

				if (loops > 5000) {
					minGap--;
					loops = 0;
				}

				loops++;


			}


		}
	}
}
