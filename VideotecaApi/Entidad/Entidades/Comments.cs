using System;
using System.Collections.Generic;

namespace Entidad.Entidades
{
    public partial class Comments
    {
        public int CommentId { get; set; }
        public string Comment { get; set; }
        public int? MovieSeriesId { get; set; }
        public string UserName { get; set; }

        public virtual MoviesAndSeries MovieSeries { get; set; }
        public virtual Users UserNameNavigation { get; set; }
    }
}
