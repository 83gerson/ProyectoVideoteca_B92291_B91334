using Entidad.Entidades;
using Microsoft.AspNetCore.Mvc;
using Negocio;
namespace VideotecaApi.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly INegocioSQL _inegocioSQL;
        public UsersController(INegocioSQL inegocioSQL)
        {
            _inegocioSQL = inegocioSQL;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region Actors
        [HttpPost]
        [Route(nameof(AgregarUsers))]
        public bool AgregarUsers(Users P_Entidad)
        {
            return _inegocioSQL.AgregarUsers(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(ConsultarUsers))]
        public List<Users> ConsultarUsers(Users P_Entidad)
        {
            return _inegocioSQL.ConsultarUsers(P_Entidad).ToList();
        }
        [HttpPost]
        [Route(nameof(ModificarUsers))]
        public bool ModificarUsers(Users P_Entidad)
        {
            return _inegocioSQL.ModificarUsers(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(EliminarUsers))]
        public bool EliminarUsers(Users P_Entidad)
        {
            return _inegocioSQL.EliminarUsers(P_Entidad);
        }
        #endregion
    }
}
