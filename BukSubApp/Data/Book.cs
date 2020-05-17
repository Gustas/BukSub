using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BukSub.Data
{
    public class Book
    {
        [Key, Required, MaxLength(50)]
        public string BookId { get; set; }
        
        [Required, MaxLength(250)]
        public string Name { get; set; }

        [Required]
        public string Text { get; set; }
        
        [Required]
        public double Price { get; set; }

        public List<BookSubscription> BookSubscriptions { get; set; }
    }
}

