using System;
using System.ComponentModel.DataAnnotations;

namespace BookingApp.Models
{
    public class Booking
    {
        public Guid ID { get; set; }

        public string Name { get; set; }
    }
}