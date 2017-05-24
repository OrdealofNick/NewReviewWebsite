using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewReviewWebsite.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }

        //navigation
        //one genre may have many artists
        public virtual ICollection<Artist> Artists { get; set; }
    }
}
