namespace ProyectoVideoteca_B92291_B91334.Models
{
    public class Ratings
    {
        public int rating_id { get; set; }
        public int rating { get; set; }
        public MoviesAndSeries MovieAndSeries { get; set; }
        public User User { get; set; }
    }
}
