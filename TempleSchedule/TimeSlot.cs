using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleSchedule {
	class TimeSlot {
		public DateTime startTime;
		public Ward assignedWard;
		public List<TimeSlot> sectionList;	//List containing timeslots from the same interval of the year

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="_startTime">Initial Start Time</param>
		public TimeSlot(DateTime _startTime) {
			this.startTime = _startTime;
		}

		public TimeSlot() {}

		public void swapWards(TimeSlot t) {

			if (t.assignedWard != null && this.assignedWard != null) {

				//Swapping Timeslots
				this.assignedWard.timeslots.Add(t);
				this.assignedWard.timeslots.Remove(this);
				t.assignedWard.timeslots.Add(this);
				t.assignedWard.timeslots.Remove(t);

				//Swapping Wards
				Ward tempWard = t.assignedWard;
				t.assignedWard = this.assignedWard;
				this.assignedWard = tempWard;
			} else if(t.assignedWard == null) {

				t.assignedWard = this.assignedWard;
				t.assignedWard.timeslots.Add(t);
				
				this.assignedWard.timeslots.Remove(this);
				this.assignedWard = null;

			} else if (this.assignedWard == null) {

				this.assignedWard = t.assignedWard;
				this.assignedWard.timeslots.Add(this);

				t.assignedWard.timeslots.Remove(t);
				t.assignedWard = null;

			}
			
		}
	}
}
