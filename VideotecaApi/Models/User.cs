namespace ProyectoVideoteca_B92291_B91334.Models
{
    public class User
    {
        public int user_id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }

        public List<Comments> Comments { get; set; }
        public List<Ratings> Ratings { get; set; }
    }
}
