using ProyectoVideoteca_B92291_B91334.Data;
using ProyectoVideoteca_B92291_B91334.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace VideotecaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesAndSeriesGenresController : ControllerBase
    {
        private readonly UCRTextContext _context;

        public MoviesAndSeriesGenresController(UCRTextContext context)
        {
            _context = context;
        }

        [HttpGet("moviesAndSeriesGenres")]
        public IActionResult GetMoviesAndSeriesGenres()
        {
            return Ok();
        }

    }
}
