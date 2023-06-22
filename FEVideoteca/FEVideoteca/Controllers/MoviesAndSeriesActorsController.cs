using FEVideoteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace FEVideoteca.Controllers
{
    public class MoviesAndSeriesActorsController : Controller
    {
        public IActionResult CreateMoviesAndSeriesActors()
        {
            return View();
        }


        public async Task<IActionResult> ConsultarMoviesAndSeriesActors()
        {

            ConexionApi objetoConexion = new ConexionApi();

            List<MoviesAndSeriesActors> lst = await objetoConexion.ConsultarMoviesAndSeriesActors(new MoviesAndSeriesActors());

            return View(lst);

        }

        public async Task<IActionResult> AgregarMoviesAndSeriesActors(MoviesAndSeriesActors P_Entidad)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.AgregarMoviesAndSeriesActors(P_Entidad);

            return RedirectToAction("ConsultarMoviesAndSeriesActors", "MoviesAndSeriesActors");

        }

        public IActionResult EditMovies(int id,int actorid, int moviesandseriesid)
        {
            //Se hace porque ya tenemos los datos listados
            MoviesAndSeriesActors objActors = new MoviesAndSeriesActors
            {
                Id = id,
                ActorId= actorid,
                MoviesSeriesId= moviesandseriesid

            };

            return View(objActors);
        }

        [HttpPost]
        public async Task<IActionResult> ModificarMoviesAndActor(MoviesAndSeriesActors P_Entidad)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.ModificarMoviesAndActor(P_Entidad);

            return RedirectToAction("ConsultarMoviesAndSeriesActors", "MoviesAndSeriesActors");

        }

        public async Task<IActionResult> EliminarMoviesAndActors(int id)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.EliminarMoviesAndActors(new MoviesAndSeriesActors { Id = id });

            return RedirectToAction("ConsultarMoviesAndSeriesActors", "MoviesAndSeriesActors");

        }
    }
}
