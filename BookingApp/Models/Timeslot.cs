using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.Models
{
    public class Timeslot
    {
        public Guid ID { get; set; }

        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime EndTime
        {
            get { return StartTime + Duration; }
        }

        public string Description { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }

        public int Capacity { get; set; }

        public bool IsAvailable
        {
            get {
                if (Bookings == null && Capacity>0) return true;
                return (Capacity - Bookings.Count > 0);
            }
        }
    }
}


