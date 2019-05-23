using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using BookingApp.Models;

namespace BookingApp.Interfaces
{
    public interface IBookingService
    {
        Task<IEnumerable<Booking>> GetBookings();

        Task<Booking> GetBooking(int id);

        Task<Booking> UpdateBooking(Booking booking);

        Task AddBooking(Booking booking);

        Task<Booking> DeleteBooking(int id);
    }
}