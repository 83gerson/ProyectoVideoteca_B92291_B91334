using System;
using System.Collections.Generic;

namespace Entidad.Entidades
{
    public partial class Users
    {
        public Users()
        {
            Comments = new HashSet<Comments>();
            Ratings = new HashSet<Ratings>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Ratings> Ratings { get; set; }
    }
}
