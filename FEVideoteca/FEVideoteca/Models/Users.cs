namespace FEVideoteca.Models
{
    public class Users
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public string Role { get; set; }

        public Users() { 
            Username = string.Empty;
            Password = string.Empty;
            ImageUrl = string.Empty;
            Role = string.Empty;
        }
    }
}
