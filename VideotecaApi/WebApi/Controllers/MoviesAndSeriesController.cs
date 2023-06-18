using Entidad.Entidades;
using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace WebApi.Controllers
{
    [Route("api/MoviesAndSeries")]
    [ApiController]
    public class MoviesAndSeriesController : Controller
    {
        private readonly INegocioSQL _inegocioSQL;
        public MoviesAndSeriesController(INegocioSQL inegocioSQL)
        {
            _inegocioSQL = inegocioSQL;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Actors
        [HttpPost]
        [Route(nameof(AgregarMovies))]
        public bool AgregarMovies(MoviesAndSeries P_Entidad)
        {
            return _inegocioSQL.AgregarMovies(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(ConsultarMovies))]
        public List<MoviesAndSeries> ConsultarMovies(MoviesAndSeries P_Entidad)
        {
            return _inegocioSQL.ConsultarMovies(P_Entidad).ToList();
        }
        [HttpPost]
        [Route(nameof(ModificarMovies))]
        public bool ModificarMovies(MoviesAndSeries P_Entidad)
        {
            return _inegocioSQL.ModificarMovies(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(EliminarMovies))]
        public bool EliminarMovies(MoviesAndSeries P_Entidad)
        {
            return _inegocioSQL.EliminarMovies(P_Entidad);
        }
        #endregion
    }
}
