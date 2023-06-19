namespace FEVideoteca.Models
{
    public class MoviesAndSeriesActors
    {
        public int Id { get; set; }
        public int MoviesSeriesId { get; set; }
        public int ActorId { get; set; }



        public MoviesAndSeriesActors() { 
        
            Id = 0;
            MoviesSeriesId = 0;
            ActorId = 0;
        
        
        }
    }
}
