namespace ProyectoVideoteca_B92291_B91334.Models
{
    public class MoviesAndSeriesActors
    {
        public int movies_series_id { get; set; }
        public int actor_id { get; set; }
        public MoviesAndSeries MovieAndSeries { get; set; }
        public Actors Actor { get; set; }
    }
}
