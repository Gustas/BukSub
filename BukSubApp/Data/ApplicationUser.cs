using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BukSub.Data
{
    public class ApplicationUser : IdentityUser
    {
        public List<BookSubscription> BookSubscriptions { get; set; }
    }
}
