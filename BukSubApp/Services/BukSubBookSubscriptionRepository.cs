using BukSub.Data;
using BukSub.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BukSubApp.Services
{
    public class BukSubBookSubscriptionRepository : IBookSubscriptionsRepository
    {
        ApplicationDbContext _dbContext;
        public BukSubBookSubscriptionRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<bool> DeleteAsync(BookSubscriptionServiceModel bookSubscription)
        {
            if (bookSubscription is null) throw new ArgumentNullException(nameof(bookSubscription));

            if (!_dbContext.Users.Any(u => u.Id == bookSubscription.UserId && u.BookSubscriptions.Any(bs => bs.BookId == bookSubscription.BookId)))
            {
                // Subscription does not exist
                return false;
            }

            var bookSubscribtion = new BookSubscription() { BookId = bookSubscription.BookId, UserId = bookSubscription.UserId };
            _dbContext.Add(bookSubscribtion).State = EntityState.Deleted;
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task SaveAsync(BookSubscriptionServiceModel bookSubscription)
        {
            if (bookSubscription is null) throw new ArgumentNullException(nameof(bookSubscription));

            if (_dbContext.Users.Any(u => u.Id == bookSubscription.UserId && u.BookSubscriptions.Any(bs => bs.BookId == bookSubscription.BookId)))
            {
                // Subscription already exists
                return;
            }

            var bookSubscribtion = new BookSubscription() { BookId = bookSubscription.BookId, UserId = bookSubscription.UserId };
            _dbContext.Add(bookSubscribtion).State = EntityState.Added;
            await _dbContext.SaveChangesAsync();
        }
    }
}
