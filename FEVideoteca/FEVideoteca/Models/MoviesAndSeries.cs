namespace FEVideoteca.Models
{
    public class MoviesAndSeries
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public int ReleaseYear { get; set; }
        public string Duration { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string NumSeasons { get; set; }
        public string NumEpisodes { get; set; }
        public string EpisodeDuration { get; set; }


        public MoviesAndSeries()
        {
            Id= 0;
            Title=String.Empty;
            Synopsis= String.Empty;
            ReleaseYear= 0;
            Duration = String.Empty;
            Director = String.Empty;
            Genre = String.Empty;
            NumSeasons = String.Empty;
            NumEpisodes = String.Empty;
            EpisodeDuration = String.Empty;

        }

    }
}
