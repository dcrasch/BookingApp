using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using BookingApp.Models;
using BookingApp.Services;
using BookingApp.Interfaces;

namespace BookingApp.Controllers
{
    [Route("api/[controller]")]
    public class BookingController : Controller
    {

        private readonly IBookingRepository _bookingService;
        public BookingController(IBookingRepository bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Booking>> Get()
        {
            var bookings = _bookingService.GetAll();
            return Ok(bookings);
        }

        [HttpGet("{id}")]
        public ActionResult<Booking> Get(Guid id)
        {
            var booking = _bookingService.Get(id);

            if (booking == null)
            {
                return NotFound();
            }

            return Ok(booking);
}

    [HttpPost]
    public ActionResult Post([FromBody] Booking value)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var booking = _bookingService.Add(value);
        return CreatedAtAction("Get", new { id = booking.ID }, booking);
    }

    [HttpDelete("{id}")]
    public ActionResult Remove(Guid id)
    {
        var booking = _bookingService.Get(id);

        if (booking == null)
        {
            return NotFound();
        }

        _bookingService.Remove(booking);
        return Ok();
    }

    // TODO update with put
    }
}
