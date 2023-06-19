using FEVideoteca.Models;
using Microsoft.AspNetCore.Mvc;

namespace FEVideoteca.Controllers
{
    public class CommentsController : Controller
    {
        public IActionResult CreateActors()
        {
            return View();
        }


        public async Task<IActionResult> ConsultarComments()
        {

            ConexionApi objetoConexion = new ConexionApi();

            List<Comments> lst = await objetoConexion.ConsultarComments(new Comments());

            return View(lst);

        }

        public async Task<IActionResult> AgregarComments(Comments P_Entidad)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.AgregarComments(P_Entidad);

            return RedirectToAction("ConsultarActors", "Actors");

        }

        public IActionResult EditComments(int id, string comment, string username, int moviesandseriesid)
        {
            //Se hace porque ya tenemos los datos listados
            Comments objActors = new Comments
            {

                CommentId = id,
                Comment = comment,
                UserName = username,
                MovieSeriesId= moviesandseriesid
            };

            return View(objActors);
        }

        [HttpPost]
        public async Task<IActionResult> ModificarComments(Comments P_Entidad)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.ModificarComments(P_Entidad);

            return RedirectToAction("ConsultarComments", "Comments");

        }

        public async Task<IActionResult> EliminarComments(int id)
        {

            ConexionApi objetoConexion = new ConexionApi();

            await objetoConexion.EliminarComments(new Comments { CommentId = id });

            return RedirectToAction("ConsultarComments", "Comments");

        }
    }
}
