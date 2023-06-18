namespace FEVideoteca.Models
{
    public class Actors
    {
        public int Id { get; set; }
        public string ActorFirstName { get; set; }
        public string ActorLastName { get; set; }

        public Actors()
        {
            Id = 0;
            ActorFirstName = string.Empty;
            ActorLastName = string.Empty;
        }
    }
}
