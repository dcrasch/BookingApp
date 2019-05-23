using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using BookingApp.Models;
using BookingApp.Interfaces;

namespace BookingApp.Services
{
    public class BookingService : IBookingService
    {
        private readonly BookingContext _context;
        public BookingService(BookingContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Booking>> GetBookings()
        {
            return await _context.Bookings.ToListAsync();
        }

        public async Task<Booking> GetBooking(int id)
        {
            return await _context.Bookings.FindAsync(id);
        }

        public async Task<Booking> UpdateBooking(Booking booking)
        {
            _context.Entry(booking).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
            return booking;
        }

        public async Task AddBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
        }

        public async Task<Booking> DeleteBooking(int id) {
            var bookingDelete = await _context.Bookings.FindAsync(id);
            if (bookingDelete == null)
            {
                return null;
            }
            _context.Bookings.Remove(bookingDelete);
            await _context.SaveChangesAsync();
            return bookingDelete;
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.Id == id);
        }

    }
}
