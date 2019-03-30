using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Xunit;

using BookingApp.Controllers;
using BookingApp.Services;
using BookingApp.Interfaces;
using BookingApp.Models;

namespace BookingApp.Tests
{
    public class BookingControllerTest
    {
        BookingController _controller;
        IBookingService _service;

        public BookingControllerTest()
        {
            _service = new SampleBookingService();
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

        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.Get().Result as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<Booking>>(okResult.Value);
            Assert.Equal(2, items.Count);
        }

        [Fact]
        public void GetById_UnknownGuidPassed_ReturnsNotFoundResult()
        {
            // Act
            var notFoundResult = _controller.Get(Guid.NewGuid());

            // Assert
            Assert.IsType<NotFoundResult>(notFoundResult.Result);
        }

        [Fact]
        public void GetById_KnownGuidPassed_ReturnsOk()
        {
            // Arange

            var existingGuid = new Guid("b94afb54-a1cb-4313-8af3-b7511551b33b");
            // Act
            var foundResult = _controller.Get(existingGuid);

            // Assert
            Assert.IsType<OkObjectResult>(foundResult.Result);
        }

        [Fact]
        public void GetById_ExistingGuidPassed_ReturnsRightItem()
        {
            // Arrange
            var existingGuid = new Guid("b94afb54-a1cb-4313-8af3-b7511551b33b");

            // Act
            var foundResult = _controller.Get(existingGuid);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(foundResult.Result);
            var booking = Assert.IsType<Booking>(okResult.Value);
            Assert.Equal(existingGuid, booking.ID);
        }

        [Fact]
        public void Add_ValidObjectPassed_ReturnsCreatedAtActionResult()
        {
            // Arrange
            var newId = Guid.NewGuid();
            var newName = "Hello world";
            // Act
            var result = _controller.Post(new Booking  { ID = newId, Name = newName} );

            // Assert
            Assert.IsType<CreatedAtActionResult>(result);
        }

        [Fact]
        public void Add_InvalidObjectPassed_ReturnsBadRequest()
        {
            // Arrange
            var newId = Guid.NewGuid();
            var nameMissingBooking = new Booking()
            {
                ID = newId
            };
            _controller.ModelState.AddModelError("Name", "Required");
            // Act
            var badResponse = _controller.Post(nameMissingBooking);

            // Assert
            Assert.IsType<BadRequestObjectResult>(badResponse);
        }

        [Fact]
        public void Add_ValidObjectPassedReturnedResponseHasCreatedItem()
        {
            // Arrange
            var newName = "Hello world";
            var booking = new Booking { Name = newName };

            // Act
            var result = _controller.Post(booking);

            // Assert
            var actionResult = Assert.IsType<CreatedAtActionResult>(result);
            var newBooking = Assert.IsType<Booking>(actionResult.Value);
            Assert.Equal(newBooking.Name, booking.Name);
        }

        [Fact]
        public void Remove_ValidGuidPassed_ReturnsOk()
        {
            // Arrange
            var existingGuid = new Guid("b94afb54-a1cb-4313-8af3-b7511551b33b");

            // Act
            var okResponse = _controller.Remove(existingGuid);

            // Assert
            Assert.IsType<OkResult>(okResponse);
        }

        [Fact]
        public void Remove_InvalidGuidPassed_ReturnsObjectNotFound()
        {
            // Arrange
            var nonExistingGuid = new Guid("b94afb54-0000-0000-0000-b7511551b33b");

            // Act
            var notFoundResponse = _controller.Remove(nonExistingGuid);

            // Assert
            Assert.IsType<NotFoundResult>(notFoundResponse);
        }
    }
}
