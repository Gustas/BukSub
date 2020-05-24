using BukSub.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BukSub.Services
{
    public interface IBookRepository
    {
        Task<BookServiceModel> GetUserBookAsync(string userId, string bookId);

        Task SaveBookAsync(BookServiceModel book);

        Task<bool> DeleteBookAsync(string bookId);

        Task<IEnumerable<BookListingItemDto>> GetBooksAsync(string userId);
    }
}