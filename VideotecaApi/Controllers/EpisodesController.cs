using ProyectoVideoteca_B92291_B91334.Data;
using ProyectoVideoteca_B92291_B91334.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace VideotecaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpisodesController : ControllerBase
    {
        private readonly UCRTextContext _context = new UCRTextContext();

        // GET api/actor/episodes
        [HttpGet("episodes")]
        public IActionResult GetEpisodes()
        {
            var episodes = _context.Episodes.ToList();
            return Ok(episodes);
        }

        // GET api/episodes/{id}
        [HttpGet("{id}")]
        public IActionResult GetEpisodes(int id)
        {
            var episodes = _context.Episodes.Find(id);
            if (episodes == null)
            {
                return NotFound();
            }
            return Ok(episodes);
        }

        // POST api/episodes
        [HttpPost]
        public IActionResult CreateActor([FromBody] Episodes episode)
        {
            _context.Episodes.Add(episode);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetEpisodes), new { id = episode.episode_id }, episode);
        }

        // PUT api/episodes/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateEpisodes(int id, [FromBody] Episodes episodeData)
        {
            var episode = _context.Episodes.Find(id);
            if (episode == null)
            {
                return NotFound();
            }

            episode.tittle = episodeData.tittle;
            episode.duration = episodeData.duration;
            episode.episode_number = episodeData.episode_number;

            _context.SaveChanges();

            return NoContent();
        }

        // DELETE api/episodes/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteEpisodes(int id)
        {
            var episode = _context.Episodes.Find(id);
            if (episode == null)
            {
                return NotFound();
            }

            _context.Episodes.Remove(episode);
            _context.SaveChanges();

            return NoContent();
        }

    }
}
