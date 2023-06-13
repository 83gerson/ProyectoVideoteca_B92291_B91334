using ProyectoVideoteca_B92291_B91334.Data;
using ProyectoVideoteca_B92291_B91334.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace VideotecaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesAndSeriesController : ControllerBase
    {
        private readonly UCRTextContext _context;

        public MoviesAndSeriesController(UCRTextContext context)
        {
            _context = context;
        }

        [HttpGet("moviesAndSeries")]
        public IActionResult GetMoviesAndSeries()
        {
            return Ok();
        }

    }
}
