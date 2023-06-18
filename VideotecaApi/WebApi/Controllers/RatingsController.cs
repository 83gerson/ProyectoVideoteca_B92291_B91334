using Entidad.Entidades;
using Microsoft.AspNetCore.Mvc;
using Negocio;
namespace VideotecaApi.Controllers
{
    [Route("api/Ratings")]
    [ApiController]
    public class RatingsController : Controller
    {
        private readonly INegocioSQL _inegocioSQL;
        public RatingsController(INegocioSQL inegocioSQL)
        {
            _inegocioSQL = inegocioSQL;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Actors
        [HttpPost]
        [Route(nameof(AgregarRatings))]
        public bool AgregarRatings(Ratings P_Entidad)
        {
            return _inegocioSQL.AgregarRatings(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(ConsultarRatings))]
        public List<Ratings> ConsultarRatings(Ratings P_Entidad)
        {
            return _inegocioSQL.ConsultarRatings(P_Entidad).ToList();
        }
        [HttpPost]
        [Route(nameof(ModificarRatings))]
        public bool ModificarRatings(Ratings P_Entidad)
        {
            return _inegocioSQL.ModificarRatings(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(EliminarRatings))]
        public bool EliminarRatings(Ratings P_Entidad)
        {
            return _inegocioSQL.EliminarRatings(P_Entidad);
        }
        #endregion
    }
}
