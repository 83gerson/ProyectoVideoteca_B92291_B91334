using ProyectoVideoteca_B92291_B91334.Models.DTO;

namespace ProyectoVideoteca_B92291_B91334.Repositories.Abstract
{
    public interface IUserAuthenticationService
    {
   
        Task<Status> LoginAsync(LoginModel model);
        Task LogoutAsync();
        Task<Status> RegisterAsync(RegistrationModel model);
        Task<Status> ChangePasswordAsync(ChangePasswordModel model, string username);
    }
}
