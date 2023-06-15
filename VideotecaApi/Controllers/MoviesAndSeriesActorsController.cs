using ProyectoVideoteca_B92291_B91334.Data;
using ProyectoVideoteca_B92291_B91334.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace VideotecaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesAndSeriesActorsController : ControllerBase
    {
        private readonly UCRTextContext _context = new UCRTextContext();

        // GET api/moviesAndSeriesActor/moviesAndSeriesActors
        [HttpGet("moviesAndSeriesActors")]
        public IActionResult GetMoviesAndSeriesActors()
        {
            var moviesAndSeriesActors = _context.MoviesAndSeriesActors.ToList();
            return Ok(moviesAndSeriesActors);
        }

        // GET api/moviesAndSeriesActors/{id}
        [HttpGet("{id}")]
        public IActionResult GetMoviesAndSeriesActors(int id)
        {
            var moviesAndSeriesActors = _context.MoviesAndSeriesActors.Find(id);
            if (moviesAndSeriesActors == null)
            {
                return NotFound();
            }
            return Ok(moviesAndSeriesActors);
        }

        // POST api/moviesAndSeriesActors
        [HttpPost]
        public IActionResult CreateMoviesAndSeriesActors([FromBody] MoviesAndSeriesActors moviesAndSeriesActors)
        {
            _context.MoviesAndSeriesActors.Add(moviesAndSeriesActors);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetMoviesAndSeriesActors), new { id = moviesAndSeriesActors.movies_series_id }, moviesAndSeriesActors);
        }
    }
}