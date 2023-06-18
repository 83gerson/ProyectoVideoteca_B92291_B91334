using System;
using System.Collections.Generic;

namespace Entidad.Entidades
{
    public partial class MoviesAndSeries
    {
        public MoviesAndSeries()
        {
            Comments = new HashSet<Comments>();
            Episodes = new HashSet<Episodes>();
            MoviesAndSeriesActors = new HashSet<MoviesAndSeriesActors>();
            Ratings = new HashSet<Ratings>();
        }

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

        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Episodes> Episodes { get; set; }
        public virtual ICollection<MoviesAndSeriesActors> MoviesAndSeriesActors { get; set; }
        public virtual ICollection<Ratings> Ratings { get; set; }
    }
}
