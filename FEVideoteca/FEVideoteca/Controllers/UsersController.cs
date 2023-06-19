using FEVideoteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace FEVideoteca.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult CreateUsers()
        {
            return View();
        }


        public async Task<IActionResult> ConsultarUsers()
        {

            ConexionApi objetoConexion = new ConexionApi();

            List<Users> lst = await objetoConexion.ConsultarUsers(new Users());

            return View(lst);

        }

        public async Task<IActionResult> AgregarUsers(Users P_Entidad)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.AgregarUsers(P_Entidad);

            return RedirectToAction("ConsultarUsers", "Users");

        }

        public IActionResult EditUsers(string username,string imageurl,string password, string role)
        {
            //Se hace porque ya tenemos los datos listados
            Users objActors = new Users
            {
                Username = username,
                ImageUrl=imageurl,
                Password=password,
                Role=role

            };

            return View(objActors);
        }

        [HttpPost]
        public async Task<IActionResult> ModificarUsers(Users P_Entidad)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.ModificarUsers(P_Entidad);

            return RedirectToAction("ConsultarUsers", "Users");

        }

        public async Task<IActionResult> EliminarUsers(string username)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.EliminarUsers(new Users { Username = username });

            return RedirectToAction("ConsultarUsers", "Users");

        }
    }
}
