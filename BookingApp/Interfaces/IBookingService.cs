using System.Collections.Generic;
using BookingApp.Models;
using System;


namespace BookingApp.Interfaces
{
    public interface IBookingService
    {
        bool DoesItemExist(Guid id);
        IEnumerable<Booking> GetAll { get; }
        Booking Get(Guid id);
        Booking Add(Booking item);
        void Update(Booking item);
        void Remove(Guid id);
    }
}