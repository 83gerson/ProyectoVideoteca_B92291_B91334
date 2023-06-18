using System;
using System.Collections.Generic;

namespace Entidad.Entidades
{
    public partial class Ratings
    {
        public int RatingId { get; set; }
        public int? MovieSeriesId { get; set; }
        public string Username { get; set; }
        public int? Rating { get; set; }

        public virtual MoviesAndSeries MovieSeries { get; set; }
        public virtual Users UsernameNavigation { get; set; }
    }
}
