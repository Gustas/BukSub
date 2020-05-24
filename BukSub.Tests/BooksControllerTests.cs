using BukSub.Controllers;
using BukSub.Models;
using BukSub.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Xunit;

namespace BukSub.Tests
{
    public class BooksControllerTests
    {
        [Fact]
        public async Task Get_Returns_Empty_200_Empty_Listing()
        {
            // Arrange
            var logger = new Mock<ILogger<BooksController>>();

            var bookRepository = new Mock<IBookRepository>();

            var context = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = new ClaimsPrincipal(new[] { new ClaimsIdentity(new[] { new Claim(ClaimTypes.NameIdentifier, "test_name_identifier") }) }) }
            };

            var booksController = new BooksController(logger.Object, bookRepository.Object);
            booksController.ControllerContext = context;

            // Act
            var getResponse = await booksController.GetAsync();

            // Assert
            var okResult = Assert.IsAssignableFrom<OkObjectResult>(getResponse);
            var bookListing = Assert.IsAssignableFrom<IEnumerable<BookListingItemDto>>(okResult.Value);
            Assert.Empty(bookListing);
        }

        [Fact]
        public async Task Get_Returns_200_NonEmpty_Listing()
        {
            // Arrange
            var logger = new Mock<ILogger<BooksController>>();

            var bookRepository = new Mock<IBookRepository>();
            bookRepository.Setup(s => s.GetBooksAsync(It.IsAny<string>())).Returns(Task.FromResult((IEnumerable<BookListingItemDto>)new[] {
                new BookListingItemDto { BookId = "IDDQ1", Name = "The Bible" },
                new BookListingItemDto { BookId = "IDDOG2", Name = "Service Manual for CAT CV-5b Forklift" }
            }));

            var context = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = new ClaimsPrincipal(new[] { new ClaimsIdentity(new[] { new Claim(ClaimTypes.NameIdentifier, "test_name_identifier") }) }) }
            };

            var booksController = new BooksController(logger.Object, bookRepository.Object);
            booksController.ControllerContext = context;

            // Act
            var getResponse = await booksController.GetAsync();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(getResponse);
            var bookListing = Assert.IsAssignableFrom<IEnumerable<BookListingItemDto>>(okResult.Value);
            Assert.Equal(2, bookListing.Count());
            Assert.Contains(bookListing, b => b.BookId == "IDDQ1" && b.Name == "The Bible" && b.SubscribedToBook == false);
            Assert.Contains(bookListing, b => b.BookId == "IDDOG2" && b.Name == "Service Manual for CAT CV-5b Forklift" && b.SubscribedToBook == false);
        }

        [Fact]
        public async Task Get_Returns_200_Book()
        {
            // Arrange
            var logger = new Mock<ILogger<BooksController>>();
            var bookRepository = new Mock<IBookRepository>();
            bookRepository.Setup(s => s.GetUserBookAsync(It.IsAny<string>(), It.IsAny<string>())).Returns(
                Task.FromResult(new BookServiceModel { BookId = "IDDQ1", Name = "The Bible", Price = 666, Text = "Jibba jabba  complete text" })
            );

            var context = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = new ClaimsPrincipal(new[] { new ClaimsIdentity(new[] { new Claim(ClaimTypes.NameIdentifier, "test_name_identifier") }) }) }
            };

            var booksController = new BooksController(logger.Object, bookRepository.Object);
            booksController.ControllerContext = context;

            // Act
            var getResponse = await booksController.GetAsync("IDDQ1");

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(getResponse);
            var book = Assert.IsType<BookDto>(okResult.Value);
            Assert.NotNull(book);
            Assert.Equal("IDDQ1", book.BookId);
            Assert.Equal("The Bible", book.Name);
            Assert.Equal(666.0, book.Price);
            Assert.Equal("Jibba jabba  complete text", book.Text);
        }

        [Fact]
        public async Task Get_Returns_404()
        {
            // Arrange
            var logger = new Mock<ILogger<BooksController>>();

            var bookRepository = new Mock<IBookRepository>();
            bookRepository.Setup(s => s.GetUserBookAsync("SOMEUSER", "IDDQ1")).Returns(Task.FromResult((BookServiceModel)null));

            var context = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = new ClaimsPrincipal(new[] { new ClaimsIdentity(new[] { new Claim(ClaimTypes.NameIdentifier, "test_name_identifier") }) }) }
            };

            var booksController = new BooksController(logger.Object, bookRepository.Object);
            booksController.ControllerContext = context;

            // Act
            var getResponse = await booksController.GetAsync("IDDQ1");

            // Assert
            Assert.IsType<NotFoundResult>(getResponse);
        }

        [Fact]
        public async Task Put_StoresBook_200()
        {
            // Arrange
            var logger = new Mock<ILogger<BooksController>>();

            var bookRepository = new Mock<IBookRepository>();

            var booksController = new BooksController(logger.Object, bookRepository.Object);

            // Act
            var putResponse = await booksController.PutAsync("IDDQ1", new PutBookDto() { Name = "SomeName", Price = 5.0, Text = "Text text" });

            // Assert
            bookRepository.Verify(e => e.SaveBookAsync(It.IsAny<BookServiceModel>()), Times.Once);
            Assert.IsType<OkResult>(putResponse);
        }

        [Fact]
        public async Task Delete_DeletesBook_200()
        {
            // Arrange
            var logger = new Mock<ILogger<BooksController>>();

            var bookRepository = new Mock<IBookRepository>();
            bookRepository.Setup(s => s.DeleteBookAsync(It.IsAny<string>())).Returns(Task.FromResult(true));

            var booksController = new BooksController(logger.Object, bookRepository.Object);

            // Act
            var deleteResponse = await booksController.DeleteAsync("IDDQD1");

            // Assert
            bookRepository.Verify(e => e.DeleteBookAsync(It.IsAny<string>()), Times.Once);
            Assert.IsType<OkResult>(deleteResponse);
        }

        [Fact]
        public async Task Delete_DeletesBook_404()
        {
            // Arrange
            var logger = new Mock<ILogger<BooksController>>();
            var bookRepository = new Mock<IBookRepository>();
            bookRepository.Setup(s => s.DeleteBookAsync(It.IsAny<string>())).Returns(Task.FromResult(false));
            var booksController = new BooksController(logger.Object, bookRepository.Object);

            // Act
            var deleteResponse = await booksController.DeleteAsync("Non-existring-book-id");

            // Assert
            bookRepository.Verify(e => e.DeleteBookAsync(It.IsAny<string>()), Times.Once);
            Assert.IsType<NotFoundResult>(deleteResponse);
        }
    }
}
