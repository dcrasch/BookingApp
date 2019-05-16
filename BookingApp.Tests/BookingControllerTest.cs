using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Xunit;

using BookingApp.Controllers;
using BookingApp.Models;
using BookingApp.Interfaces;

using BookingApp.Tests.Services;

namespace BookingApp.Tests
{
    public class BookingControllerTest
    {
        BookingsController _controller;
        IBookingService _service;

        public BookingControllerTest()
        {
            _service = new SampleBookingService();
            _controller = new BookingsController(_service);
        }

        [Fact]
        public async void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = await _controller.GetBookings();
            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        /*
        [Fact]
        public async void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = await _controller.GetBookings();

            // Assert
            var items = Assert.IsType<OkObjectResult>(okResult.Result);
            Assert.Equal(2, items.Count);
        }

        [Fact]
        public void GetById_UnknownIdPassed_ReturnsNotFoundResult()
        {
            // Arange
            var nonExistingId = -1;
            // Act
            var notFoundResult = _controller.GetBooking(nonExistingId);

            // Assert
            Assert.IsType<NotFoundResult>(notFoundResult.Result);
        }

        [Fact]
        public void GetById_KnownIdPassed_ReturnsOk()
        {
            // Arange
            var existingId = 1;
            // Act
            var foundResult = _controller.GetBooking(existingId);

            // Assert
            Assert.IsType<OkObjectResult>(foundResult.Result);
        }

        [Fact]
        public void GetById_ExistingIdPassed_ReturnsRightItem()
        {
            // Arrange
            var existingId = 1;

            // Act
            var foundResult = _controller.GetBooking(existingId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(foundResult.Result);
            var booking = Assert.IsType<Booking>(okResult.Value);
            Assert.Equal(existingId, booking.Id);
        }

        [Fact]
        public void Add_ValidObjectPassed_ReturnsCreatedAtActionResult()
        {
            // Arrange
            var newId = 3;
            var newName = "Hello world";
            // Act
            var result = _controller.PostBooking(
                new Booking  { Id = newId, Name = newName}
            );

            // Assert
            Assert.IsType<CreatedAtActionResult>(result);
        }

        [Fact]
        public async void Add_InvalidObjectPassed_ReturnsBadRequest()
        {
            // Arrange
            var newId = 3;
            var nameMissingBooking = new Booking()
            {
                Id = newId
            };
            _controller.ModelState.AddModelError("Name", "Required");
            // Act
            var badResponse = _controller.PostBooking(nameMissingBooking);

            // Assert
            Assert.IsType<BadRequestObjectResult>(badResponse.Result);
        }

        [Fact]
        public void Add_ValidObjectPassedReturnedResponseHasCreatedItem()
        {
            // Arrange
            var newName = "Hello world";
            var booking = new Booking { Name = newName };

            // Act
            var result = _controller.PostBooking(booking);

            // Assert
            var actionResult = Assert.IsType<CreatedAtActionResult>(result);
            var newBooking = Assert.IsType<Booking>(actionResult.Value);
            Assert.Equal(newBooking.Name, booking.Name);
        }

        [Fact]
        public void Remove_ValidIdPassed_ReturnsOk()
        {
            // Arrange
            var existingId = 1;

            // Act
            var okResponse = _controller.DeleteBooking(existingId);

            // Assert
            Assert.IsType<OkResult>(okResponse);
        }

        [Fact]
        public void Remove_InvalidIdPassed_ReturnsObjectNotFound()
        {
            // Arrange
            var nonExistingId = -1;

            // Act
            var notFoundResponse = _controller.DeleteBooking(nonExistingId);

            // Assert
            Assert.IsType<NotFoundResult>(notFoundResponse);
        }

        [Fact]
        public void Update_ValidObjectPassedReturnedResponseNoContent()
        {
            // Arrange
            var existingId = 1;
            var newName = "Hello world";
            var booking = new Booking { Id=existingId, Name = newName };

            // Act
            var result = _controller.PutBooking(existingId, booking);
            // Assert
            var actionResult = Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public void Update_InvalidObjectPassedReturnedBadRequest()
        {
            // Arrange
            var existingId = 1;
            var nameMissingBooking = new Booking()
            {
                Id = existingId
            };
            _controller.ModelState.AddModelError("Name", "Required");
            // Act
            var badResponse = _controller.PutBooking(existingId, nameMissingBooking);

            // Assert
            Assert.IsType<BadRequestObjectResult>(badResponse);
        }

        [Fact]
        public void Update_NonexistingObjectPassedReturnNotfound()
        {
            // Arrange
            var nonExistingId = -1;
            var booking = new Booking()
            {
                Id = nonExistingId,
                Name = "Does not exists"
            };

            // Act
            var notfoundResponse = _controller.PutBooking(nonExistingId, booking);

            // Assert
            Assert.IsType<NotFoundResult>(notfoundResponse);
        }
        */
    }
}
