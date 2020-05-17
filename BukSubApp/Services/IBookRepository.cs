using BukSub.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BukSub.Services
{
    public interface IBookRepository
    {
        Task<BookServiceModel> GetBookAsync(string bookId);

        Task SaveBookAsync(BookServiceModel book);

        Task<bool> DeleteBookAsync(string bookId);

        Task<IEnumerable<BookListingItemDto>> GetBooksAsync(string userId);
    }
}