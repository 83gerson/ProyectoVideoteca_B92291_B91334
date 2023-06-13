namespace ProyectoVideoteca_B92291_B91334.Models
{
    public class Actors
    {
        public int Id { get; set; }
        public string actor_first_name { get; set; }
        public string actor_last_name { get; set; }

        public ICollection<MoviesAndSeriesActors> MoviesAndSeriesActors { get; set; }
    }
}
