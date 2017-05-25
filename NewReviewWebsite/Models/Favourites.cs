namespace NewReviewWebsite.Models {
    public class Favourites {
        public string EMail { get; set; } //FK
        public int ArtistID { get; set; } //FK
        public string ArtistName { get; set; } //FK
        public int AlbumID { get; set; } //FK
        public string AlbumName { get; set; } //FK

        //navigation
        //each user may favourite many artists
        public virtual Artist Artists { get; set; }
       
        //each user may favourite many genres
        public virtual Genre Genres { get; set; }

        //many users may have many favourites
        public virtual ApplicationUser User { get; set; }
    }
}