using Entidad.Entidades;
using Microsoft.AspNetCore.Mvc;
using Negocio;
namespace VideotecaApi.Controllers
{
    [Route("api/Actors")]
    [ApiController]
    public class ActorsController : Controller
    {
        private readonly INegocioSQL _inegocioSQL;
        public ActorsController(INegocioSQL inegocioSQL)
        {
            _inegocioSQL = inegocioSQL;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Actors
        [HttpPost]
        [Route(nameof(AgregarActors))]
        public bool AgregarActors(Actors P_Entidad)
        {
            return _inegocioSQL.AgregarActors(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(ConsultarActors))]
        public List<Actors> ConsultarActors(Actors P_Entidad)
        {
            return _inegocioSQL.ConsultarActors(P_Entidad).ToList();
        }
        [HttpPost]
        [Route(nameof(ModificarActors))]
        public bool ModificarActors(Actors P_Entidad)
        {
            return _inegocioSQL.ModificarActors(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(EliminarActors))]
        public bool EliminarActors(Actors P_Entidad)
        {
            return _inegocioSQL.EliminarActors(P_Entidad);
        }
        #endregion
    }
}
