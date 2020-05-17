using System.ComponentModel.DataAnnotations;

namespace BukSub.Models
{
    /// <summary>
    /// Represent book with title, complete text and price.
    /// </summary>
    public class BookDto
    {

        /// <summary>
        /// Uniquely identifies Book
        /// </summary>
        [Required]
        public string BookId { get; set; }

        /// <summary>
        /// Name of the book / title
        /// </summary>
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        /// <summary>
        /// Full text of the book content
        /// </summary>
        [Required]
        public string Text { get; set; }

        /// <summary>
        /// Purchase price of the book
        /// </summary>
        [Required]
        public double Price { get; set; }
    }
}
