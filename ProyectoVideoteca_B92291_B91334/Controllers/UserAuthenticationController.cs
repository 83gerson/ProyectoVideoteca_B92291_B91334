using ProyectoVideoteca_B92291_B91334.Models.DTO;
using ProyectoVideoteca_B92291_B91334.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoVideoteca_B92291_B91334.Controllers
{
    public class UserAuthenticationController : Controller
    {
        private readonly IUserAuthenticationService _authService;
        public UserAuthenticationController(IUserAuthenticationService authService)
        {
            this._authService = authService;
        }

        
        public IActionResult Login()
        {
            return View();
        }

       
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var result = await _authService.LoginAsync(model);

            if(result.StatusCode==1 && User.IsInRole("admin"))
            {
                return RedirectToAction("Display", "Admin");
            }
            else if (result.StatusCode == 1 && User.IsInRole("user"))
            {

                return RedirectToAction("Index", "User");

            }
            else if (result.StatusCode == 1 && User.IsInRole("user"))
            {
                return RedirectToAction("Index", "SuperAdmin");
            }
            else
            {
                TempData["msg"] = result.Message;
                return RedirectToAction(nameof(Login));
            }
        }
       
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(RegistrationModel model)
        {
            if(!ModelState.IsValid) { return View(model); }
            model.Role = "admin";
            var result = await this._authService.RegisterAsync(model);
            TempData["msg"] = result.Message;
            return RedirectToAction(nameof(Registration));
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await this._authService.LogoutAsync();  
            return RedirectToAction(nameof(Login));
        }
        //[AllowAnonymous]
        //public async Task<IActionResult> RegisterAdmin()
        //{
        //    RegistrationModel model = new RegistrationModel
        //    {
        //        Username="admin",
        //        Email="admin@gmail.com",
        //        FirstName="John",
        //        LastName="Doe",
        //        Password="Admin@12345#"
        //    };
        //    model.Role = "admin";
        //    var result = await this._authService.RegisterAsync(model);
        //    return Ok(result);
        //}

        [Authorize]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult>ChangePassword(ChangePasswordModel model)
        {
            if (!ModelState.IsValid)
              return View(model);
            var result = await _authService.ChangePasswordAsync(model, User.Identity.Name);
            TempData["msg"] = result.Message;
            return RedirectToAction(nameof(ChangePassword));
        }

    }
}
