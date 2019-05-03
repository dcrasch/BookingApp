using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Xunit;

using BookingApp.Controllers;
using BookingApp.Interfaces;
using BookingApp.Models;

namespace BookingApp.Tests
{
    public class TimeslotTest 
    {
        public TimeslotTest()
        {
        }

        [Fact]
        public void EndTime_ReturnEndTimeWithDuration()
        {
            // Arrange
            DateTime endTime = new DateTime(1970, 1, 2);
            // Act
            Timeslot t = new Timeslot
            {
                StartTime = new DateTime(1970, 1, 1),
                Duration = new TimeSpan(1, 0, 0, 0)
            };
            // Assert
            Assert.Equal(endTime, t.EndTime);
        }

        [Fact]
        public void Add_BookingReturnsOK()
        {
            // Arrange
            Timeslot timeslot = new Timeslot
            {
                Capacity = 1,
                Bookings = new List<Booking>()
            };
            timeslot.Bookings.Add(new Booking());
            // Assert
            Assert.Equal(1, timeslot.Bookings.Count);
        }

        [Fact]
        public void Capacity_AddBookingReturnIsAvailable()
        {
            // Arrange
            Timeslot timeslot = new Timeslot
            {
                Capacity = 1,
            };
            // Assert
            Assert.True(timeslot.IsAvailable);
        }

        [Fact]
        public void Capacity_AddBookingReturnNotIsAvailable()
        {
            // Arrange
            Timeslot timeslot = new Timeslot
            {
                Capacity = 1,
                Bookings = new List<Booking>()

            };
            timeslot.Bookings.Add(new Booking());
            // Assert
            Assert.False(timeslot.IsAvailable);
        }

        [Fact]
        public void Capacity_NoBookingsReturnIsAvailable()
        {
            // Arrange
            Timeslot timeslot = new Timeslot
            {
                Capacity = 1,
            };
            // Assert
            Assert.True(timeslot.IsAvailable);
        }

    }
}
