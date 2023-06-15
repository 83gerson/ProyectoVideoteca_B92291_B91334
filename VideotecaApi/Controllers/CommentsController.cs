using ProyectoVideoteca_B92291_B91334.Data;
using ProyectoVideoteca_B92291_B91334.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace VideotecaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly UCRTextContext _context= new UCRTextContext();

 

        // GET api/comments
        [HttpGet]
        public async Task<IActionResult> GetComments()
        {
            var comments = await _context.Comments.ToListAsync();
            return Ok(comments);
        }

        // GET api/comments/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetComment(int id)
        {
            var comment = await _context.Comments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            return Ok(comment);
        }

        // POST api/comments
        [HttpPost]
        public async Task<IActionResult> CreateComment([FromBody] Comments comment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetComment), new { id = comment.comment_id }, comment);
        }

        // PUT api/comments/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateComment(int id, [FromBody] Comments comment)
        {
            if (id != comment.comment_id || !ModelState.IsValid)
            {
                return BadRequest();
            }
            _context.Entry(comment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE api/comments/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            var comment = await _context.Comments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
