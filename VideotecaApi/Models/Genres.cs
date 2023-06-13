namespace ProyectoVideoteca_B92291_B91334.Models
{
    public class Genres
    {
        public int Id { get; set; }
        public string genre_name { get; set; }

        public List<MoviesAndSeriesGenres> MovieAndSeriesGenres { get; set; }
    }
}
