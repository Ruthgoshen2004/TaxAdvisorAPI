using Microsoft.AspNetCore.Mvc;
using MyApi.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxAdvisorController : ControllerBase
    {
        // GET: api/<TaxAdvisorController>
        public static List<TaxAdvisor> taxAdvisors = new List<TaxAdvisor>
        {
            new TaxAdvisor
            {
                   Id=998767908,
                  Name="ruth",
                   Age=56
            }
        };
        // GET: api/<MyController>
        [HttpGet]
        public List<TaxAdvisor> Get()
        {
            return taxAdvisors;
        }

        // GET api/<MyController>/5
        [HttpGet("{id}")]
        public ActionResult<TaxAdvisor> Get(int id)
        {
            TaxAdvisor taxAdvisorst = taxAdvisors.Find(e => e.Id == id);
            if (taxAdvisorst is null)
                return NotFound();
            return taxAdvisorst;
        }

        // POST api/<MyController>
        [HttpPost]
        public void Post([FromBody] TaxAdvisor taxAdvisors1)
        {
            taxAdvisors.Add(taxAdvisors1);

        }

        // PUT api/<MyController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TaxAdvisor taxAdvisors1)
        {
            if (taxAdvisors1 is null)
                return NotFound();
            TaxAdvisor cs = taxAdvisors.Find(e => e.Id == id);
            if (cs is null)
                return BadRequest();
            else
                cs.Age = taxAdvisors1.Age;
            cs.Name = taxAdvisors1.Name;
            cs.Id = taxAdvisors1.Id;
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, string status,[FromBody] TaxAdvisor taxAdvisors1)
        {
            if (taxAdvisors1 is null)
                return NotFound();
            TaxAdvisor cs = taxAdvisors.Find(e => e.Id == id);
            if (cs is null)
                return BadRequest();
            else
               cs.Status = status;
            return NoContent();
        }
        // DELETE api/<MyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            TaxAdvisor c = taxAdvisors.Find(e => e.Id == id);
            taxAdvisors.Remove(c);

        }
    }
}
