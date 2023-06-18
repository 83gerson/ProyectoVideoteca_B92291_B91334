using Entidad.Entidades;
using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace WebApi.Controllers
{

    [Route("api/MoviesAndSeriesActors")]
    [ApiController]
    public class MoviesAndSeriesActorsController : Controller
    {
        private readonly INegocioSQL _inegocioSQL;
        public MoviesAndSeriesActorsController(INegocioSQL inegocioSQL)
        {
            _inegocioSQL = inegocioSQL;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Actors
        [HttpPost]
        [Route(nameof(AgregarMoviesAndSeriesActors))]
        public bool AgregarMoviesAndSeriesActors(MoviesAndSeriesActors P_Entidad)
        {
            return _inegocioSQL.AgregarMoviesAndSeriesActors(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(ConsultarMoviesAndSeriesActors))]
        public List<MoviesAndSeriesActors> ConsultarMoviesAndSeriesActors(MoviesAndSeriesActors P_Entidad)
        {
            return _inegocioSQL.ConsultarMoviesAndSeriesActors(P_Entidad).ToList();
        }
        [HttpPost]
        [Route(nameof(ModificarMoviesAndActor))]
        public bool ModificarMoviesAndActor(MoviesAndSeriesActors P_Entidad)
        {
            return _inegocioSQL.ModificarMoviesAndActor(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(EliminarMoviesAndActors))]
        public bool EliminarMoviesAndActors(MoviesAndSeriesActors P_Entidad)
        {
            return _inegocioSQL.EliminarMoviesAndActors(P_Entidad);
        }
        #endregion
    }
}
