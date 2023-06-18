using System;
using System.Collections.Generic;

namespace Entidad.Entidades
{
    public partial class Episodes
    {
        public int EpisodeId { get; set; }
        public string Tittle { get; set; }
        public string Duration { get; set; }
        public int EpisodeNumber { get; set; }
        public int? MoviesSeriesId { get; set; }

        public virtual MoviesAndSeries MoviesSeries { get; set; }
    }
}
