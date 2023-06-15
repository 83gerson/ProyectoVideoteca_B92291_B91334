using ProyectoVideoteca_B92291_B91334.Data;
using ProyectoVideoteca_B92291_B91334.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace VideotecaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UCRTextContext _context= new UCRTextContext();

        // GET api/user
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }

        // GET api/user/{username}
        [HttpGet("{username}")]
        public IActionResult GetUser(string username)
        {
            var user = _context.Users.Find(username);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // POST api/user
        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetUser), new { username = user.Username }, user);
        }

        // PUT api/user/{username}
        [HttpPut("{username}")]
        public IActionResult UpdateUser(string username, User updatedUser)
        {
            var user = _context.Users.Find(username);
            if (user == null)
            {
                return NotFound();
            }

            user.Password = updatedUser.Password;
            user.ImageUrl = updatedUser.ImageUrl;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE api/user/{username}
        [HttpDelete("{username}")]
        public IActionResult DeleteUser(string username)
        {
            var user = _context.Users.Find(username);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
