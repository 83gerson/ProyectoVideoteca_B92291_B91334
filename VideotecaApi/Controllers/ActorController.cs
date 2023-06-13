using ProyectoVideoteca_B92291_B91334.Data;
using ProyectoVideoteca_B92291_B91334.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace VideotecaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly UCRTextContext _context;

        public ActorController(UCRTextContext context)
        {
            _context = context;
        }

        [HttpGet("actors")]
        public IActionResult GetActors()
        {
            return Ok();
        }

    }
}
