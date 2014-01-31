using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleSchedule {
	class TimeSlot {
		public DateTime startTime;
		public Ward assignedWard;		

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="_startTime">Initial Start Time</param>
		public TimeSlot(DateTime _startTime) {
			this.startTime = _startTime;
		}
	}
}
