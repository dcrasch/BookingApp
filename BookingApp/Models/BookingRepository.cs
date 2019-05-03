using System.Collections.Generic;
using System.Linq;
using System;

using BookingApp.Models;
using BookingApp.Interfaces;

namespace BookingApp.Models
{
    public class BookingRepository : IBookingRepository
    {
        readonly BookingContext _bookingContext;
        public BookingRepository(BookingContext context)
        {
            _bookingContext = context;
        }
        public bool DoesItemExist(Guid id)
        {
            return _bookingContext.Bookings.Any(item => item.ID == id);
        }

        public Booking Get(Guid id)
        {
            return  _bookingContext.Bookings.FirstOrDefault(item => item.ID == id);
        }

        public IEnumerable<Booking> GetAll()
        {
           return _bookingContext.Bookings.ToList();
        }


        public Booking Add(Booking item)
        {
            _bookingContext.Bookings.Add(item);
            _bookingContext.SaveChanges();
            return item;
        }

        public void Update(Booking booking, Booking newBooking)
        {
            booking.Name = newBooking.Name;
            _bookingContext.SaveChanges();
        }

        public void Remove(Booking booking)
        {
            _bookingContext.Remove(booking);
            _bookingContext.SaveChanges();

        }
    }
}