using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

using BookingApp.Controllers;
using BookingApp.Models;

namespace BookingApp.Tests
{
    public class BookingControllerTest
    {
        /* TODO
         *         readonly BookingsController _controller;

        [Fact]
        public async void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = await _controller.GetBookings();
            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.GetBookings();

            // Assert
            var items = Assert.IsType<List<Booking>>(okResult.Result);
            Assert.Equal(2, items.Count);
        }

        [Fact]
        public void GetById_UnknownGuidPassed_ReturnsNotFoundResult()
        {
            // Act
            var notFoundResult = _controller.GetBooking(Guid.NewGuid());

            // Assert
            Assert.IsType<NotFoundResult>(notFoundResult.Result);
        }

        [Fact]
        public void GetById_KnownGuidPassed_ReturnsOk()
        {
            // Arange

            var existingGuid = new Guid("b94afb54-a1cb-4313-8af3-b7511551b33b");
            // Act
            var foundResult = _controller.GetBooking(existingGuid);

            // Assert
            Assert.IsType<OkObjectResult>(foundResult.Result);
        }

        [Fact]
        public void GetById_ExistingGuidPassed_ReturnsRightItem()
        {
            // Arrange
            var existingGuid = new Guid("b94afb54-a1cb-4313-8af3-b7511551b33b");

            // Act
            var foundResult = _controller.GetBooking(existingGuid);

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
            var result = _controller.PostBooking(new Booking  { ID = newId, Name = newName} );

            // Assert
            Assert.IsType<CreatedAtActionResult>(result);
        }

        [Fact]
        public async void Add_InvalidObjectPassed_ReturnsBadRequest()
        {
            // Arrange
            var newId = Guid.NewGuid();
            var nameMissingBooking = new Booking()
            {
                ID = newId
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
        public void Remove_ValidGuidPassed_ReturnsOk()
        {
            // Arrange
            var existingGuid = new Guid("b94afb54-a1cb-4313-8af3-b7511551b33b");

            // Act
            var okResponse = _controller.DeleteBooking(existingGuid);

            // Assert
            Assert.IsType<OkResult>(okResponse);
        }

        [Fact]
        public void Remove_InvalidGuidPassed_ReturnsObjectNotFound()
        {
            // Arrange
            var nonExistingGuid = new Guid("b94afb54-0000-0000-0000-b7511551b33b");

            // Act
            var notFoundResponse = _controller.DeleteBooking(nonExistingGuid);

            // Assert
            Assert.IsType<NotFoundResult>(notFoundResponse);
        }

        [Fact]
        public void Update_ValidObjectPassedReturnedResponseNoContent()
        {
            // Arrange
            var existingGuid = new Guid("b94afb54-a1cb-4313-8af3-b7511551b33b");
            var newName = "Hello world";
            var booking = new Booking { ID=existingGuid, Name = newName };

            // Act
            var result = _controller.PutBooking(existingGuid, booking);
            // Assert
            var actionResult = Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public void Update_InvalidObjectPassedReturnedBadRequest()
        {
            // Arrange
            var existingGuid = new Guid("b94afb54-a1cb-4313-8af3-b7511551b33b");
            var nameMissingBooking = new Booking()
            {
                ID = existingGuid
            };
            _controller.ModelState.AddModelError("Name", "Required");
            // Act
            var badResponse = _controller.PutBooking(existingGuid, nameMissingBooking);

            // Assert
            Assert.IsType<BadRequestObjectResult>(badResponse);
        }

        [Fact]
        public void Update_NonexistingObjectPassedReturnNotfound()
        {
            // Arrange
            var nonExistingGuid = new Guid("b94afb54-a1cb-4313-8af3-b7511551b33c");
            var booking = new Booking()
            {
                ID = nonExistingGuid,
                Name = "Does not exists"
            };

            // Act
            var notfoundResponse = _controller.PutBooking(nonExistingGuid, booking);

            // Assert
            Assert.IsType<NotFoundResult>(notfoundResponse);
        }
        */
    }
}
