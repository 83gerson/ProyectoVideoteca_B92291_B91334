using ProyectoVideoteca_B92291_B91334.Data;
using ProyectoVideoteca_B92291_B91334.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;

namespace VideotecaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesAndSeriesController : ControllerBase
    {
        private readonly UCRTextContext _context = new UCRTextContext();


        // GET api/moviesandseries
        [HttpGet]
        public IActionResult GetMoviesAndSeries()
        {
            var moviesAndSeries = _context.MoviesAndSeries.ToList();
            return Ok(moviesAndSeries);
        }

        // GET api/moviesandseries/{id}
        [HttpGet("{id}")]
        public IActionResult GetMoviesAndSeries(int id)
        {
            var moviesAndSeries = _context.MoviesAndSeries.Find(id);
            if (moviesAndSeries == null)
            {
                return NotFound();
            }
            return Ok(moviesAndSeries);
        }

        // POST api/moviesandseries
        [HttpPost]
        public IActionResult CreateMoviesAndSeries(MoviesAndSeries moviesAndSeries)
        {
            _context.MoviesAndSeries.Add(moviesAndSeries);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetMoviesAndSeries), new { id = moviesAndSeries.id }, moviesAndSeries);
        }

        // PUT api/moviesandseries/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateMoviesAndSeries(int id, MoviesAndSeries updatedMoviesAndSeries)
        {
            var moviesAndSeries = _context.MoviesAndSeries.Find(id);
            if (moviesAndSeries == null)
            {
                return NotFound();
            }

            moviesAndSeries.title = updatedMoviesAndSeries.title;
            moviesAndSeries.synopsis = updatedMoviesAndSeries.synopsis;
            moviesAndSeries.release_year = updatedMoviesAndSeries.release_year;
            // Actualiza el resto de propiedades según sea necesario

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE api/moviesandseries/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteMoviesAndSeries(int id)
        {
            var moviesAndSeries = _context.MoviesAndSeries.Find(id);
            if (moviesAndSeries == null)
            {
                return NotFound();
            }

            _context.MoviesAndSeries.Remove(moviesAndSeries);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
