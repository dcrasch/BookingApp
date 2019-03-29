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

        private readonly IBookingRepository _bookingRepository;
        public BookingController(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Booking>> Get()
        {
            var items = _bookingRepository.All;
            return Ok(items);
        }
    }
}
