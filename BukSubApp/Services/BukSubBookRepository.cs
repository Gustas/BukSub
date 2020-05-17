using BukSub.Data;
using BukSub.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BukSub.Services
{
    public class BukSubBookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public BukSubBookRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new System.ArgumentNullException(nameof(dbContext));
        }

        public async Task<BookServiceModel> GetBookAsync(string id)
        {
            if (id is null) throw new ArgumentNullException(nameof(id));

            var book = await _dbContext.Books.FindAsync(id);

            return book != null ? new BookServiceModel { BookId = book.BookId, Name = book.Name, Price = book.Price, Text = book.Text } : null;
        }

        public async Task SaveBookAsync(BookServiceModel book)
        {
            if (book is null) throw new ArgumentNullException(nameof(book));

            var b = await _dbContext.Books.FindAsync(book.BookId);
            if (b == null)
            {
                b = new Book() { BookId = book.BookId };
                _dbContext.Books.Add(b);
            }
            b.Name = book.Name;
            b.Text = book.Text;
            b.Price = book.Price;

            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteBookAsync(string bookId)
        {
            if (bookId is null) throw new ArgumentNullException(nameof(bookId));

            var book = await _dbContext.Books.FindAsync(bookId);
            if (book == null)
                return false;

            _dbContext.Books.Remove(book);
            await _dbContext.SaveChangesAsync();
            
            return true;
        }

        public async Task<IEnumerable<BookListingItemDto>> GetBooksAsync(string userId)
        {
            if (userId is null) throw new ArgumentNullException(nameof(userId));

            var result = await _dbContext.Books
                .Select(s => new BookListingItemDto { BookId = s.BookId, Name = s.Name, SubscribedToBook = s.BookSubscriptions.Any(bs => bs.UserId == userId) })
                .ToListAsync();

            return result;
        }
    }
}