using Entidad.Entidades;
using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace WebApi.Controllers
{
    [Route("api/Comments")]
    [ApiController]
    public class CommentsController : Controller
    {
        private readonly INegocioSQL _inegocioSQL;
        public CommentsController(INegocioSQL inegocioSQL)
        {
            _inegocioSQL = inegocioSQL;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Actors
        [HttpPost]
        [Route(nameof(AgregarComments))]
        public bool AgregarComments(Comments P_Entidad)
        {
            return _inegocioSQL.AgregarComments(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(ConsultarComments))]
        public List<Comments> ConsultarComments(Comments P_Entidad)
        {
            return _inegocioSQL.ConsultarComments(P_Entidad).ToList();
        }
        [HttpPost]
        [Route(nameof(ModificarComments))]
        public bool ModificarComments(Comments P_Entidad)
        {
            return _inegocioSQL.ModificarComments(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(EliminarComments))]
        public bool EliminarComments(Comments P_Entidad)
        {
            return _inegocioSQL.EliminarComments(P_Entidad);
        }
        #endregion
    }
}
