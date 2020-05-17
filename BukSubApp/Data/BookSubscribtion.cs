using BukSub.Data;
using System.ComponentModel.DataAnnotations;

namespace BukSub.Data
{
    public class BookSubscription
    {
        [Required, MaxLength(50)]
        public string BookId { get; set; }
        
        public Book Book { get; set; }

        [Required, MaxLength(450)]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
        
    }
}
