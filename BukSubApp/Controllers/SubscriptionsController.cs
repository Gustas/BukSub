using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using System.Threading.Tasks;
using BukSub.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BukSub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionsController : ControllerBase
    {
        private readonly ILogger<SubscriptionsController> _logger;
        private readonly IBookSubscriptionsRepository _bookSubscriptionsRepository;
        private readonly IBookRepository _bookRepository;


        public SubscriptionsController(ILogger<SubscriptionsController> logger, IBookSubscriptionsRepository bookSubscriptionsRepository, IBookRepository bookRepository)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _bookSubscriptionsRepository = bookSubscriptionsRepository ?? throw new ArgumentNullException(nameof(bookSubscriptionsRepository));
            _bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
        }

        [HttpPost("{*bookId}")]
        public async Task<IActionResult> PostAsync([NotNull] string bookId)
        {
            var book = await _bookRepository.GetBookAsync(bookId);
            if (book == null)
            {
                return NotFound();
            }

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var subscription = new BookSubscriptionServiceModel() { BookId = bookId, UserId = userId };
            await _bookSubscriptionsRepository.SaveAsync(subscription);

            return Ok();
        }

        [HttpDelete("{*bookId}")]

        public async Task<IActionResult> DeleteAsync([NotNull] string bookId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var subscription = new BookSubscriptionServiceModel() { BookId = bookId, UserId = userId };
            var deleted = await _bookSubscriptionsRepository.DeleteAsync(subscription);
            if (!deleted)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
