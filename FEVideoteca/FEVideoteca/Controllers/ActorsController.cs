using FEVideoteca.Models;
using Microsoft.AspNetCore.Mvc;


namespace FEVideoteca.Controllers
{
    public class ActorsController : Controller
    {

        public IActionResult CreateActors()
        {
            return View();
        }


        public async Task<IActionResult> ConsultarActors() {

            ConexionApi objetoConexion = new ConexionApi();

            List<Actors> lst = await objetoConexion.ConsultarActors(new Actors());

            return View(lst);

        }

        public async Task<IActionResult> AgregarActors(Actors P_Entidad)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.AgregarActors(P_Entidad);

            return RedirectToAction("ConsultarActors", "Actors");

        }

        public IActionResult EditActors(int id, string actorfirstname, string actorlastname)
        {
            //Se hace porque ya tenemos los datos listados
            Actors objActors = new Actors
            {

                Id = id,
                ActorFirstName = actorfirstname,
                ActorLastName = actorlastname,

            };

            return View(objActors);
        }

        [HttpPost]
        public async Task<IActionResult> ModificarActors(Actors P_Entidad)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.ModificarActors(P_Entidad);

            return RedirectToAction("ConsultarActors", "Actors");

        }

        public async Task<IActionResult> EliminarActors(int id)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.EliminarActors(new Actors { Id = id });

            return RedirectToAction("ConsultarActors", "Actors");

        }
    }
}
