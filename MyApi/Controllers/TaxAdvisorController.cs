using Microsoft.AspNetCore.Mvc;
using MyApi.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxAdvisorController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public  TaxAdvisorController(DataContext context)
        {
            _dataContext = context;
        }
        // GET: api/<TaxAdvisorController>
        
        // GET: api/<MyController>
        [HttpGet]
        public List<TaxAdvisor> Get()
        {
            return _dataContext.taxadvisors;
        }

        // GET api/<MyController>/5
        [HttpGet("{id}")]
        public ActionResult<TaxAdvisor> Get(int id)
        {
            TaxAdvisor taxAdvisorst = _dataContext.taxadvisors.Find(e => e.Id == id);
            if (taxAdvisorst is null)
                return NotFound();
            return taxAdvisorst;
        }

        // POST api/<MyController>
        [HttpPost]
        public void Post([FromBody] TaxAdvisor taxAdvisors1)
        {
            _dataContext.taxadvisors.Add(taxAdvisors1);

        }

        // PUT api/<MyController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TaxAdvisor taxAdvisors1)
        {
            if (taxAdvisors1 is null)
                return NotFound();
            TaxAdvisor cs = _dataContext.taxadvisors.Find(e => e.Id == id);
            if (cs is null)
                return BadRequest();
            else
                cs.Age = taxAdvisors1.Age;
            cs.Name = taxAdvisors1.Name;
            cs.Id = taxAdvisors1.Id;
            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, bool status,[FromBody] TaxAdvisor taxAdvisors1)
        {
            if (taxAdvisors1 is null)
                return NotFound();
            TaxAdvisor cs = _dataContext.taxadvisors.Find(e => e.Id == id);
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
            TaxAdvisor c = _dataContext.taxadvisors.Find(e => e.Id == id);
            _dataContext.taxadvisors.Remove(c);

        }
    }
}
