using ProyectoVideoteca_B92291_B91334.Data;
using ProyectoVideoteca_B92291_B91334.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;

namespace VideotecaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private readonly UCRTextContext _context= new UCRTextContext();

        // GET api/ratings
        [HttpGet]
        public IActionResult GetRatings()
        {
            var ratings = _context.Ratings.ToList();
            return Ok(ratings);
        }

        // GET api/ratings/{id}
        [HttpGet("{id}")]
        public IActionResult GetRating(int id)
        {
            var rating = _context.Ratings.Find(id);
            if (rating == null)
            {
                return NotFound();
            }
            return Ok(rating);
        }

        // POST api/ratings
        [HttpPost]
        public IActionResult CreateRating(Ratings rating)
        {
            _context.Ratings.Add(rating);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetRating), new { id = rating.rating_id }, rating);
        }

        // PUT api/ratings/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateRating(int id, Ratings updatedRating)
        {
            var rating = _context.Ratings.Find(id);
            if (rating == null)
            {
                return NotFound();
            }

            rating.rating = updatedRating.rating;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE api/ratings/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteRating(int id)
        {
            var rating = _context.Ratings.Find(id);
            if (rating == null)
            {
                return NotFound();
            }

            _context.Ratings.Remove(rating);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
