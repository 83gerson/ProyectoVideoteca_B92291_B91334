using System.ComponentModel.DataAnnotations;

namespace ProyectoVideoteca_B92291_B91334.Models.DTO
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
