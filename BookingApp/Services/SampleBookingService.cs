using System.Collections.Generic;
using System.Linq;
using System;

using BookingApp.Models;
using BookingApp.Interfaces;

namespace BookingApp.Services
{
    public class SampleBookingService : IBookingService
    {
        private List<Booking> _bookingList;

        public SampleBookingService()
        {
            InitializeData();
        }

        public bool DoesItemExist(Guid id)
        {
            return _bookingList.Any(item => item.ID == id);
        }

        public Booking Get(Guid id)
        {
            return _bookingList.FirstOrDefault(item => item.ID == id);
        }

        public IEnumerable<Booking> GetAll()
        {
           return _bookingList.ToList();
        }


        public Booking Add(Booking item)
        {
            _bookingList.Add(item);
            return item;
        }

        public void Update(Booking booking, Booking newBooking)
        {            
            var bookingId = this.Get(booking.ID);
            var index = _bookingList.IndexOf(bookingId);
            _bookingList.RemoveAt(index);
            _bookingList.Insert(index, newBooking);
        }

        public void Remove(Booking booking)
        {
            _bookingList.Remove(this.Get(booking.ID));
        }

        private void InitializeData()
        {
            _bookingList = new List<Booking>();

            var booking1 = new Booking
            {
                ID = new Guid("fd48a062-8908-485b-a793-63acf440e781"),
                Name = "IT is Alkmaar"
            };

            var booking2 = new Booking
            {
                ID = new Guid("b94afb54-a1cb-4313-8af3-b7511551b33b"),
                Name = "Bunq hackaton"
            };
            _bookingList.Add(booking1);
            _bookingList.Add(booking2);
        }
    }
}