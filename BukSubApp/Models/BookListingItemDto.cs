using System.ComponentModel.DataAnnotations;

namespace BukSub.Models
{
    /// <summary>
    /// Model that represents one book in a list of books
    /// </summary>
    public class BookListingItemDto
    {
        /// <summary>
        /// Id of the book
        /// </summary>
        [Required]
        public string BookId { get; set; }

        /// <summary>
        /// Title of the book
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Set to true if user is susbcribed to book
        /// </summary>
        [Required]
        public bool SubscribedToBook { get; set; }
    }
}