using Microsoft.AspNetCore.Mvc;

namespace ProyectoVideoteca_B92291_B91334.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ManageUser()
        {
            return View();
        }
    }
}
