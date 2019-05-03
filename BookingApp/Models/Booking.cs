using System;
using System.ComponentModel.DataAnnotations;

namespace BookingApp.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Timeslot BookedTimeslot { get; set; }
    }
}