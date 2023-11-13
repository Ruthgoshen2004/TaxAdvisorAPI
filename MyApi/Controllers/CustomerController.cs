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
        private readonly DataContext _dataContext;
        public CustomerController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        // GET: api/<MyController>
        [HttpGet]
        public List<Castomer> Get()
        {
            return _dataContext.castomers;
        }

        // GET api/<MyController>/5
        [HttpGet("{id}")]
        public ActionResult <Castomer> Get(int id)
        {
            Castomer castomer = _dataContext.castomers.Find(e=> e.Id==id);
            if (castomer is null)
                return NotFound();
            return castomer;
        }

        // POST api/<MyController>
        [HttpPost]
        public void Post([FromBody] Castomer castomer)
        {
            _dataContext.castomers.Add(castomer);

        }

        // PUT api/<MyController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Castomer castomer)
        {
            if (castomer is null)
                return NotFound();
            Castomer cs= _dataContext.castomers.Find(e=> e.Id==id);
            if (cs is null)
                return BadRequest();
            else
                cs.Age=castomer.Age;
               cs.Name=castomer.Name;
               cs.Id=castomer.Id;
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id,bool status, [FromBody] Castomer castomer)
        {
            if (castomer is null)
                return NotFound();
            Castomer cs = _dataContext.castomers.Find(e => e.Id == id);
            if (cs is null)
                return BadRequest();
            else
                cs.Status= status;
            return NoContent();
        }


        // DELETE api/<MyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Castomer c= _dataContext.castomers.Find(e=> e.Id==id);
            _dataContext.castomers.Remove(c);

        }

        
    }
}
