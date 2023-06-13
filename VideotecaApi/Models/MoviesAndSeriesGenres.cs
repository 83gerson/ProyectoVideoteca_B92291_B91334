namespace ProyectoVideoteca_B92291_B91334.Models
{
    public class MoviesAndSeriesGenres
    {
        public int movie_series_id { get; set; }
        public int genre_id { get; set; }
        public MoviesAndSeries MovieAndSeries { get; set; }
        public Genres Genre { get; set; }
    }
}
