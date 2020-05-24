using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using System.Threading.Tasks;
using BukSub.Models;
using BukSub.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BukSub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private readonly IBookRepository _bookRepository;

        public BooksController(ILogger<BooksController> logger, IBookRepository bookRepository)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BookListingItemDto>))]
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var books = await _bookRepository.GetBooksAsync(userId);
            return Ok(books);
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BookDto>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{*bookId}")]
        public async Task<IActionResult> GetAsync([NotNull]string bookId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var book = await _bookRepository.GetUserBookAsync(userId, bookId);
            if (book == null)
            {
                return NotFound();
            }

            return Ok(new BookDto() { BookId = book.BookId, Name = book.Name, Price = book.Price, Text = book.Text });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPut("{*bookId}")]
        public async Task<IActionResult> PutAsync([NotNull]string bookId, [FromBody] PutBookDto book)
        {
            await _bookRepository.SaveBookAsync(new BookServiceModel() { BookId = bookId, Name = book.Name, Price = book.Price, Text = book.Text });
            return Ok();
        }

        [HttpDelete("{*bookId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteAsync([NotNull]string bookId)
        {
            var deleted = await _bookRepository.DeleteBookAsync(bookId);
            if (!deleted)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
