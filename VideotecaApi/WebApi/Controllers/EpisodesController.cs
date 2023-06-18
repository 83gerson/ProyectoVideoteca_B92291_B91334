using Entidad.Entidades;
using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace WebApi.Controllers
{
    public class EpisodesController : Controller
    {
        private readonly INegocioSQL _inegocioSQL;
        public EpisodesController(INegocioSQL inegocioSQL)
        {
            _inegocioSQL = inegocioSQL;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Actors
        [HttpPost]
        [Route(nameof(AgregarEpisodes))]
        public bool AgregarEpisodes(Episodes P_Entidad)
        {
            return _inegocioSQL.AgregarEpisode(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(ConsultarEpisodes))]
        public List<Episodes> ConsultarEpisodes(Episodes P_Entidad)
        {
            return _inegocioSQL.ConsultarEpisodes(P_Entidad).ToList();
        }
        [HttpPost]
        [Route(nameof(ModificarEpisodes))]
        public bool ModificarEpisodes(Episodes P_Entidad)
        {
            return _inegocioSQL.ModificarEpisodes(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(EliminarEpisodes))]
        public bool EliminarEpisodes(Episodes P_Entidad)
        {
            return _inegocioSQL.EliminarEpisodes(P_Entidad);
        }
        #endregion
    }
}
