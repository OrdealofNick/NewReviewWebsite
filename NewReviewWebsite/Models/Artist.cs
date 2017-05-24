using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewReviewWebsite.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }
        public int AlbumID { get; set; }//FK

        //navigation properties
        //one artist may have many albums
        public virtual ICollection<Album> Albums { get; set; }

    }
}
