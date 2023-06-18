using System;
using System.Collections.Generic;

namespace Entidad.Entidades
{
    public partial class Actors
    {
        public Actors()
        {
            MoviesAndSeriesActors = new HashSet<MoviesAndSeriesActors>();
        }

        public int Id { get; set; }
        public string ActorFirstName { get; set; }
        public string ActorLastName { get; set; }

        public virtual ICollection<MoviesAndSeriesActors> MoviesAndSeriesActors { get; set; }
    }
}
