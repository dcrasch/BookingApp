using System.Collections.Generic;
using System.Linq;
using System;

using BookingApp.Models;
using BookingApp.Interfaces;

namespace BookingApp.Services
{
    public class SampleBookingRepository : IBookingRepository
    {
        private List<Booking> _bookingList;

        public SampleBookingRepository()
        {
            InitializeData();
        }

        public IEnumerable<Booking> All
        {
            get { return _bookingList; }
        }

        public bool DoesItemExist(Guid id)
        {
            return _bookingList.Any(item => item.ID == id);
        }

        public Booking Find(Guid id)
        {
            return _bookingList.FirstOrDefault(item => item.ID == id);
        }

        public void Insert(Booking item)
        {
            _bookingList.Add(item);
        }

        public void Update(Booking item)
        {
            var todoItem = this.Find(item.ID);
            var index = _bookingList.IndexOf(todoItem);
            _bookingList.RemoveAt(index);
            _bookingList.Insert(index, item);
        }

        public void Delete(Guid id)
        {
            _bookingList.Remove(this.Find(id));
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