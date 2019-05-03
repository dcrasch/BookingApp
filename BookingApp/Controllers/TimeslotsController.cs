using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookingApp.Models;

namespace BookingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeslotsController : ControllerBase
    {
        private readonly BookingContext _context;

        public TimeslotsController(BookingContext context)
        {
            _context = context;
        }

        // GET: api/Timeslots
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Timeslot>>> GetTimeslot()
        {
            return await _context.Timeslot.ToListAsync();
        }

        // GET: api/Timeslots/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Timeslot>> GetTimeslot(int id)
        {
            var timeslot = await _context.Timeslot.FindAsync(id);

            if (timeslot == null)
            {
                return NotFound();
            }

            return timeslot;
        }

        // PUT: api/Timeslots/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTimeslot(int id, Timeslot timeslot)
        {
            if (id != timeslot.Id)
            {
                return BadRequest();
            }

            _context.Entry(timeslot).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TimeslotExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Timeslots
        [HttpPost]
        public async Task<ActionResult<Timeslot>> PostTimeslot(Timeslot timeslot)
        {
            _context.Timeslot.Add(timeslot);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTimeslot", new { id = timeslot.Id }, timeslot);
        }

        // DELETE: api/Timeslots/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Timeslot>> DeleteTimeslot(int id)
        {
            var timeslot = await _context.Timeslot.FindAsync(id);
            if (timeslot == null)
            {
                return NotFound();
            }

            _context.Timeslot.Remove(timeslot);
            await _context.SaveChangesAsync();

            return timeslot;
        }

        private bool TimeslotExists(int id)
        {
            return _context.Timeslot.Any(e => e.Id == id);
        }
    }
}
