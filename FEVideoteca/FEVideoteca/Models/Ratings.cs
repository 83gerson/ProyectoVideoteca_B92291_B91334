namespace FEVideoteca.Models
{
    public class Ratings
    {
        public int RatingId { get; set; }
        public int MovieSeriesId { get; set; }
        public string Username { get; set; }
        public int Rating { get; set; }

        public Ratings() { 
            RatingId = 0;
            MovieSeriesId = 0;
            Username = string.Empty;
            Rating = 0;
        }
    }
}
