using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewReviewWebsite.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string AlbumName { get; set; }
        public int ArtistID { get; set; }//FK
        public int Rating { get; set; }
        public string Length { get; set; }
        public int ReleaseYear { get; set; }//This if for the year exclusively
        public string ReleaseDate { get; set; }//this excludes the year
        public int GenreID { get; set; }//FK
        public string Label { get; set; }
        public string Review { get; set; }

        //navigation
        //each album may have many artists
        public virtual Artist Artists { get; set; }

        //each album may have one genre
        public virtual Genre Genres { get; set; }

    }
}
