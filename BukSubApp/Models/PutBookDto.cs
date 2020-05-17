using System.ComponentModel.DataAnnotations;

namespace BukSub.Models
{
    /// <summary>
    /// Represent book update/repalce model
    /// </summary>
    public class PutBookDto
    {
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
