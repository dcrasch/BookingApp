using System;
using System.Collections.Generic;

namespace BookingApp.Models
{
    public class Timeslot
    {
        public int Id { get; set; }

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
                if (Capacity <= 0) return false;
                if (Bookings == null) return true;
                return (Capacity - Bookings.Count > 0);
            }
        }
    }
}


