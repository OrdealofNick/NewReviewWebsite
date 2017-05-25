using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace NewReviewWebsite.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string EMail { get; set; } //PK
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        //navigation properties
        //one user may have many favourites
        public virtual ICollection<Favourites> Favourites { get; set; }
    }
}
