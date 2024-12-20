using CodeFirstRelation.Data.Entities;
using CodeFirstRelation.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstRelation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static List<User> _users = new List<User>()
     {
         new User {Id = 1, Name = "Serhat Uzun", Email = "seerhatuzun@gmail.com"},
         new User {Id = 1, Name = "Elifnur Kaya", Email = "seerhatuzun@gmail.com"},
         new User {Id = 1, Name = "Barlas Uzun", Email = "barlas@gmail.com"},
     };
        private readonly PatikaSecondDbContext _context;
        public UserController(PatikaSecondDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetUsers()
        {
            return Ok(_context.Users);
        }

        [HttpGet("{id:int}")]
        public ActionResult GetUser(int id)
        {
            var user = _context.Users.Find(id);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPost("{id:int}")]
        public ActionResult PostUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return CreatedAtAction("GetUsers", new { id = user.Id }, user);
        }

    }
}
