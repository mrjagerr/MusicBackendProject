using Microsoft.AspNetCore.Mvc;
using static MusicBackendProject.Data.ApplicationDbContect;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MusicBackendProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
       
        
            private readonly ApplicationDbContext _context;
            public SongsController(ApplicationDbContext context)
            {
                _context = context;
            }
            // GET: api/<SongsController>
            // Get All
            [HttpGet]
        public IActionResult Get()
        {
            var songs =_context.Songs.ToList();
            return StatusCode(200, songs);
        }

        // GET api/<SongsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var song = _context.Songs.Find(id);
            if(song == null)
            {
                return NotFound();
            }
            return Ok(song);
        }
        

        // POST api/<SongsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SongsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SongsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
