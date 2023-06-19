using FEVideoteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace FEVideoteca.Controllers
{
    public class EpisodesController : Controller
    {
        public IActionResult CreateEpisodes()
        {
            return View();
        }


        public async Task<IActionResult> ConsultarEpisodes()
        {

            ConexionApi objetoConexion = new ConexionApi();

            List<Episodes> lst = await objetoConexion.ConsultarEpisodes(new Episodes());

            return View(lst);

        }

        public async Task<IActionResult> AgregarEpisodes(Episodes P_Entidad)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.AgregarEpisodes(P_Entidad);

            return RedirectToAction("ConsultarEpisodes", "Episodes");

        }

        public IActionResult EditEpisodes(int id, string tittle, string duration, int episodenumber,int moviesseriesid)
        {
            //Se hace porque ya tenemos los datos listados
            Episodes objActors = new Episodes
            {
                Tittle=tittle,
                Duration=duration,
                EpisodeNumber=episodenumber,
                EpisodeId=id,
                MoviesSeriesId=moviesseriesid

            };

            return View(objActors);
        }

        [HttpPost]
        public async Task<IActionResult> ModificarEpisodes(Episodes P_Entidad)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.ModificarEpisodes(P_Entidad);

            return RedirectToAction("ConsultarEpisodes", "Episodes");

        }

        public async Task<IActionResult> EliminarEpisodes(int id)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.EliminarEpisodes(new Episodes { EpisodeId = id });

            return RedirectToAction("ConsultarEpisodes", "Episodes");

        }
    }
}
