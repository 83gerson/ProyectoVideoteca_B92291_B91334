using System.ComponentModel.DataAnnotations;

namespace ProyectoVideoteca_B92291_B91334.Models.DTO
{
    public class ChangePasswordModel
    {
        [Required]
        public string ? CurrentPassword { get; set; }

        [Required]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*[#$^+=!*()@%&]).{6,}$",ErrorMessage ="Minimum length 6 and must contain  1 Uppercase,1 lowercase, 1 special character and 1 digit")]
        public string? NewPassword { get; set; }
        [Required]
        [Compare("NewPassword")]
        public string ? PasswordConfirm { get; set; }
        
    }
}
