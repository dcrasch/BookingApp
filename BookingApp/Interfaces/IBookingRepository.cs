using System.Collections.Generic;
using BookingApp.Models;
using System;


namespace BookingApp.Interfaces
{
    public interface IBookingRepository
    {
        bool DoesItemExist(Guid id);
        IEnumerable<Booking> All { get; }
        Booking Find(Guid id);
        void Insert(Booking item);
        void Update(Booking item);
        void Delete(Guid id);
    }
}