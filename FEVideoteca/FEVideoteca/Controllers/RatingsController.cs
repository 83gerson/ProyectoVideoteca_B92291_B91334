using FEVideoteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace FEVideoteca.Controllers
{
    public class RatingsController : Controller
    {
        public IActionResult CreateRatings()
        {
            return View();
        }


        public async Task<IActionResult> ConsultarRatings()
        {

            ConexionApi objetoConexion = new ConexionApi();

            List<Ratings> lst = await objetoConexion.ConsultarRatings(new Ratings());

            return View(lst);

        }

        public async Task<IActionResult> AgregarRatings(Ratings P_Entidad)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.AgregarRatings(P_Entidad);

            return RedirectToAction("ConsultarRatings", "Ratings");

        }

        public IActionResult EditRatings(int id, int rating, string username,int moviesandseriesid)
        {
            //Se hace porque ya tenemos los datos listados
            Ratings objActors = new Ratings
            {

                 RatingId = id,
                 Rating=rating,
                 Username=username,
                 MovieSeriesId=moviesandseriesid

            };

            return View(objActors);
        }

        [HttpPost]
        public async Task<IActionResult> ModificarRatings(Ratings P_Entidad)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.ModificarRatings(P_Entidad);

            return RedirectToAction("ConsultarRatings", "Ratings");

        }

        public async Task<IActionResult> EliminarRatings(int id)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.EliminarRatings(new Ratings { RatingId = id });

            return RedirectToAction("ConsultarRatings", "Ratings");

        }
    }
}
