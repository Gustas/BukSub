using BukSub.Controllers;
using BukSub.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Xunit;

namespace BukSub.Tests
{
    public class SubscriptionsControllerTests
    {
        [Fact]
        public async Task Post_Stroes_Subscription_200()
        {
            // Arrange
            var logger = new Mock<ILogger<SubscriptionsController>>();

            var bookSubscriptionRepository = new Mock<IBookSubscriptionsRepository>();

            var bookRepository = new Mock<IBookRepository>();
            bookRepository.Setup(s => s.GetUserBookAsync(It.IsAny<string>(), It.IsAny<string>())).Returns(Task.FromResult(new BookServiceModel() { BookId = "IDDQD", Name = "The Bible", Price = 666.0, Text = "Text text" }));

            var context = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = new ClaimsPrincipal(new[] { new ClaimsIdentity(new[] { new Claim(ClaimTypes.NameIdentifier, "test_name_identifier") }) }) }
            };

            var bookSubsController = new SubscriptionsController(logger.Object, bookSubscriptionRepository.Object, bookRepository.Object);
            bookSubsController.ControllerContext = context;

            // Act
            var postResponse = await bookSubsController.PostAsync("IDDQD");

            // Assert
            Assert.IsType<OkResult>(postResponse);
            bookSubscriptionRepository.Verify(v => v.SaveAsync(It.IsAny<BookSubscriptionServiceModel>()));
        }

        [Fact]
        public async Task Post_Returns_404()
        {
            // Arrange
            var logger = new Mock<ILogger<SubscriptionsController>>();

            var bookSubscriptionRepository = new Mock<IBookSubscriptionsRepository>();

            var bookRepository = new Mock<IBookRepository>();

            var context = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = new ClaimsPrincipal(new[] { new ClaimsIdentity(new[] { new Claim(ClaimTypes.NameIdentifier, "test_name_identifier") }) }) }
            };

            var bookSubsController = new SubscriptionsController(logger.Object, bookSubscriptionRepository.Object, bookRepository.Object);
            bookSubsController.ControllerContext = context;

            // Act
            var postResponse = await bookSubsController.PostAsync("IDDQD");

            // Assert
            Assert.IsType<NotFoundResult>(postResponse);
        }

        [Fact]
        public async Task Delete_Deletes_Subscription_200()
        {
            // Arrange
            var logger = new Mock<ILogger<SubscriptionsController>>();

            var bookSubscriptionRepository = new Mock<IBookSubscriptionsRepository>();
            bookSubscriptionRepository.Setup(s => s.DeleteAsync(It.IsAny<BookSubscriptionServiceModel>())).Returns(Task.FromResult(true));

            var bookRepository = new Mock<IBookRepository>();

            var context = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = new ClaimsPrincipal(new[] { new ClaimsIdentity(new[] { new Claim(ClaimTypes.NameIdentifier, "test_name_identifier") }) }) }
            };

            var bookSubsController = new SubscriptionsController(logger.Object, bookSubscriptionRepository.Object, bookRepository.Object);
            bookSubsController.ControllerContext = context;

            // Act
            var deleteResponse = await bookSubsController.DeleteAsync("IDDQD");

            // Assert
            Assert.IsType<OkResult>(deleteResponse);
        }

        [Fact]
        public async Task Delete_Returns_404()
        {
            // Arrange
            var logger = new Mock<ILogger<SubscriptionsController>>();

            var bookSubscriptionRepository = new Mock<IBookSubscriptionsRepository>();
            bookSubscriptionRepository.Setup(s => s.DeleteAsync(It.IsAny<BookSubscriptionServiceModel>())).Returns(Task.FromResult(false));

            var bookRepository = new Mock<IBookRepository>();

            var context = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = new ClaimsPrincipal(new[] { new ClaimsIdentity(new[] { new Claim(ClaimTypes.NameIdentifier, "test_name_identifier") }) }) }
            };

            var bookSubsController = new SubscriptionsController(logger.Object, bookSubscriptionRepository.Object, bookRepository.Object);
            bookSubsController.ControllerContext = context;

            // Act
            var deleteResponse = await bookSubsController.DeleteAsync("IDDQD");

            // Assert
            Assert.IsType<NotFoundResult>(deleteResponse);
        }
    }
}
