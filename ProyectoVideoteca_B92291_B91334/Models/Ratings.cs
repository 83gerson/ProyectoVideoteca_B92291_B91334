﻿namespace ProyectoVideoteca_B92291_B91334.Models
{
    public class Ratings
    {
        public int rating_id { get; set; }
        
        public int movie_series_id { get; set; }

        public int user_id { get; set; }

        public int rating { get; set; }
    }
}
