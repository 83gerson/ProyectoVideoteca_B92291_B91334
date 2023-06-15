namespace ProyectoVideoteca_B92291_B91334.Models
{
    public class Comments
    {
        public int comment_id { get; set; }
        public string comment { get; set; }
        public int movie_series_id { get; set; }
        public int username{ get; set; }

        public MoviesAndSeries MovieAndSeries { get; set; }
        public User User { get; set; }
    }

}
