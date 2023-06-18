using System;
using System.Collections.Generic;

namespace Entidad.Entidades
{
    public partial class MoviesAndSeriesActors
    {
        public int Id { get; set; }
        public int? MoviesSeriesId { get; set; }
        public int? ActorId { get; set; }

        public virtual Actors Actor { get; set; }
        public virtual MoviesAndSeries MoviesSeries { get; set; }
    }
}
