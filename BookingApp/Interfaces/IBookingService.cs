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
        Task<IEnumerable<Booking>> GetBookingsAsync();

        Task<Booking> GetBookingAsync(int id);

        Task<Booking> UpdateBookingAsync(Booking booking);

        Task AddBookingAsync(Booking booking);

        Task<Booking> DeleteBookingAsync(int id);
    }
}