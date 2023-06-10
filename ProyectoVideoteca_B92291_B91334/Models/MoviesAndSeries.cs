namespace ProyectoVideoteca_B92291_B91334.Models
{
    public class MoviesAndSeries
    {
        public int id { get; set; }
        public string title { get; set; }
        public string synopsis { get; set; }
        public int release_year { get; set; }
        public string duration { get; set; }
        public string director { get; set; }
        public string genre_id { get; set; }
        public string num_seasons { get; set; }
        public string num_episodes { get; set; }
        public string episode_duration { get; set; }
        public string movie_cover { get; set; }
        public string data_added { get; set; }

        public List<Comments> Comments { get; set; }
        public List<Ratings> Ratings { get; set; }
        public List<Episodes> Episodes { get; set; }
        public List<MoviesAndSeriesGenres> Genres { get; set; }
        public List<MoviesAndSeriesActors> Actors { get; set; }
    }
}
