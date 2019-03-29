using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using Xunit;
using BookingApp.Controllers;
using BookingApp.Services;
using BookingApp.Interfaces;

namespace BookingApp.Tests
{
    public class BookingControllerTest
    {
        BookingController _controller;
        IBookingRepository _service;

        public BookingControllerTest()
        {
            _service = new SampleBookingRepository();
            _controller = new BookingController(_service);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.Get();
            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }
    }
}
