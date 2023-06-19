namespace FEVideoteca.Models
{
    public class Episodes
    {
        public int EpisodeId { get; set; }
        public string Tittle { get; set; }
        public string Duration { get; set; }
        public int EpisodeNumber { get; set; }
        public int? MoviesSeriesId { get; set; }


        public Episodes()
        {
            EpisodeId = 0;
            Tittle=String.Empty;
            Duration = String.Empty;
            EpisodeNumber = 0;
            MoviesSeriesId = 0;
        }
    }
}
