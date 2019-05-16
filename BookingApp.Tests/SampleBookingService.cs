using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

using BookingApp.Models;
using BookingApp.Interfaces;

namespace BookingApp.Tests.Services
{
    public class SampleBookingService : IBookingService
    {
        private List<Booking> _bookingList = new List<Booking>();

        public SampleBookingService()
        {
            InitializeData();
        }

        public async Task<IEnumerable<Booking>> GetBookingsAsync()
        {
            return _bookingList;
        }

        public async Task<Booking> GetBookingAsync(int id)
        {
            return _bookingList.FirstOrDefault(item => item.Id == id);
        }

        public async Task<Booking> UpdateBookingAsync(Booking booking)
        {
            var index = _bookingList.IndexOf(booking);
            _bookingList.RemoveAt(index);
            _bookingList.Insert(index, booking);
            return booking;
        }

        public async Task AddBookingAsync(Booking booking)
        {
            _bookingList.Add(booking);
            return;
        }

        public async Task<Booking> DeleteBookingAsync(int id)
        {
            Booking booking = await GetBookingAsync(id);
            var index = _bookingList.IndexOf(booking);
            _bookingList.RemoveAt(index);
            return booking;
        }

        private void InitializeData()
        {
            _bookingList.Add(
                new Booking
                {
                    Id = 1,
                    Name = "IT Is Alkmaar"
                });
            _bookingList.Add(
                new Booking
                {
                    Id = 2,
                    Name = "Bunq Hackaton"
                });
        }
    }
}
