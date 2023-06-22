using FEVideoteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace FEVideoteca.Controllers
{
    public class MoviesAndSeriesController : Controller
    {
        public IActionResult CreateMoviesAndSeries()
        {
            return View();
        }


        public async Task<IActionResult> ConsultarMoviesAndSeries()
        {

            ConexionApi objetoConexion = new ConexionApi();

            List<MoviesAndSeries> lst = await objetoConexion.ConsultarMovies(new MoviesAndSeries());

            return View(lst);

        }

        public async Task<IActionResult> AgregarMovies(MoviesAndSeries P_Entidad)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.AgregarMovies(P_Entidad);

            return RedirectToAction("ConsultarMoviesAndSeries", "MoviesAndSeries");

        }

        public IActionResult EditMovies(int id, string duration, string episodeduration, string director,string genre,string numepisodes
                                        ,string numseasons,int releaseyear,string synopsis,string title )
        {
            //Se hace porque ya tenemos los datos listados
            MoviesAndSeries objActors = new MoviesAndSeries
            {
                Id = id,
                Director=director,
                Duration = duration,
                EpisodeDuration= episodeduration,
                Genre= genre,
                NumEpisodes= numepisodes,
                NumSeasons= numseasons,
                ReleaseYear= releaseyear,
                Synopsis= synopsis,
                Title=title

            };

            return View(objActors);
        }

        [HttpPost]
        public async Task<IActionResult> ModificarMovies(MoviesAndSeries P_Entidad)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.ModificarMovies(P_Entidad);

            return RedirectToAction("ConsultarMoviesAndSeries", "MoviesAndSeries");

        }

        public async Task<IActionResult> EliminarMovies(int id)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.EliminarMovies(new MoviesAndSeries { Id = id });

            return RedirectToAction("ConsultarMoviesAndSeries", "MoviesAndSeries");

        }
    }
}
