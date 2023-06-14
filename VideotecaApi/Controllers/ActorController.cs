using ProyectoVideoteca_B92291_B91334.Data;
using ProyectoVideoteca_B92291_B91334.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace VideotecaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly UCRTextContext _context = new UCRTextContext();



        // GET api/actor/actors
        [HttpGet("actors")]
        public IActionResult GetActors()
        {
            var actors = _context.Actors.ToList();
            return Ok(actors);
        }

        // GET api/actor/{id}
        [HttpGet("{id}")]
        public IActionResult GetActor(int id)
        {
            var actor = _context.Actors.Find(id);
            if (actor == null)
            {
                return NotFound();
            }
            return Ok(actor);
        }

        // POST api/actor
        [HttpPost]
        public IActionResult CreateActor([FromBody] Actors actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetActor), new { id = actor.Id }, actor);
        }

        // PUT api/actor/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateActor(int id, [FromBody] Actors actorData)
        {
            var actor = _context.Actors.Find(id);
            if (actor == null)
            {
                return NotFound();
            }

            actor.actor_first_name = actorData.actor_first_name;
            actor.actor_last_name = actorData.actor_last_name;

            _context.SaveChanges();

            return NoContent();
        }

        // DELETE api/actor/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteActor(int id)
        {
            var actor = _context.Actors.Find(id);
            if (actor == null)
            {
                return NotFound();
            }

            _context.Actors.Remove(actor);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
