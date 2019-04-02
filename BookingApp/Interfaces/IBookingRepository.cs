using System;
using System.Collections.Generic;
using BookingApp.Models;

namespace BookingApp.Interfaces
{
    public interface IBookingRepository
    {
        bool DoesItemExist(Guid id);
        IEnumerable<Booking> GetAll();
        Booking Get(Guid id);
        Booking Add(Booking booking);
        void Update(Booking booking, Booking newBooking);
        void Remove(Booking booking);
    }
}