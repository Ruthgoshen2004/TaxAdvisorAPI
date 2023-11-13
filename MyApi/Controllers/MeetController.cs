using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Protocol;
using MyApi.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetController : ControllerBase
    {
       private readonly DataContext _dataContext;
        public MeetController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        // GET: api/<MeetController>
        [HttpGet]
        public IEnumerable<Meeting> Get()
        {
            return _dataContext.meeting;
        }

        // GET api/<MeetController>/5
        [HttpGet("{id}")]
        public ActionResult <Meeting> Get(int IDmeet2)
        {
            if (IDmeet2 is 0)
                return NotFound();
            Meeting meet= _dataContext.meeting.Find(e => e.IDmeet == IDmeet2);
            if (meet is null)
                return NotFound();
            return meet;

        }

        // POST api/<MeetController>
        [HttpPost]
        public void Post([FromBody] Meeting meet)
        {
            _dataContext.meeting.Add(meet);
        }

        // PUT api/<MeetController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Meeting meet )
        {
            if (meet is null)
                return NotFound();
            Meeting m= _dataContext.meeting.Find(e=> e==meet);
            if (m is null)
                return NotFound();
            m.CastomerId = meet.CastomerId;
            m.IDmeet=meet.IDmeet;
            m.Hour = meet.Hour;
            m.Durationofmeeting1 = meet.Durationofmeeting1;
            m.Date=meet.Date;
            m.TaxAdvisorId=meet.TaxAdvisorId;
            return NoContent();
        }

        // DELETE api/<MeetController>/5
        [HttpDelete("{id}")]
        public void Delete(Meeting meet)
        {
            _dataContext.meeting.Add(meet);
        }
    }
}
