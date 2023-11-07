using Microsoft.AspNetCore.Mvc;
using MyApi.Entities;
using System.ComponentModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public static List<Castomer> castomers = new List<Castomer>
        {
            new Castomer
            {
                   Status="work",
                   Id=998767908,
                  Name="ruth",
                   Age=56
            }
        };
        // GET: api/<MyController>
        [HttpGet]
        public List<Castomer> Get()
        {
            return castomers;
        }

        // GET api/<MyController>/5
        [HttpGet("{id}")]
        public ActionResult <Castomer> Get(int id)
        {
            Castomer castomer = castomers.Find(e=> e.Id==id);
            if (castomer is null)
                return NotFound();
            return castomer;
        }

        // POST api/<MyController>
        [HttpPost]
        public void Post([FromBody] Castomer castomer)
        {
            castomers.Add(castomer);

        }

        // PUT api/<MyController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Castomer castomer)
        {
            if (castomer is null)
                return NotFound();
            Castomer cs=castomers.Find(e=> e.Id==id);
            if (cs is null)
                return BadRequest();
            else
                cs.Age=castomer.Age;
               cs.Name=castomer.Name;
               cs.Id=castomer.Id;
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id,string status, [FromBody] Castomer castomer)
        {
            if (castomer is null)
                return NotFound();
            Castomer cs = castomers.Find(e => e.Id == id);
            if (cs is null)
                return BadRequest();
            else
                cs.Status=status;
            return NoContent();
        }


        // DELETE api/<MyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Castomer c=castomers.Find(e=> e.Id==id);
            castomers.Remove(c);

        }

        
    }
}
