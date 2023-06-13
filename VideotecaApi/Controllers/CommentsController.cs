using ProyectoVideoteca_B92291_B91334.Data;
using ProyectoVideoteca_B92291_B91334.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace VideotecaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly UCRTextContext _context;

        public CommentsController(UCRTextContext context)
        {
            _context = context;
        }

        [HttpGet("comments")]
        public IActionResult GetComments()
        {
            return Ok();
        }

    }
}
