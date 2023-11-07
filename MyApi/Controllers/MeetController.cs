using Microsoft.AspNetCore.Mvc;
using MyApi.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetController : ControllerBase
    {
        public static List<Meeting> meeting = new List<Meeting>
        {
            new Meeting
            {
                    Date="09/07/23",
                    Hour="23:00",
                   Durationofmeeting1=45
            }
        };
        // GET: api/<MeetController>
        [HttpGet]
        public IEnumerable<Meeting> Get()
        {
            return meeting;
        }

        // GET api/<MeetController>/5
        [HttpGet("{id}")]
        public ActionResult <Meeting> Get(string Hour)
        {
            if (Hour is null)
                return NotFound();
            Meeting meet=meeting.Find(e=> e.Hour==Hour);
            if (meet is null)
                return NotFound();
            return meet;

        }

        // POST api/<MeetController>
        [HttpPost]
        public void Post([FromBody] Meeting meet)
        {
               meeting.Add(meet);
        }

        // PUT api/<MeetController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Meeting meet )
        {
            if (meet is null)
                return NotFound();
            Meeting m=meeting.Find(e=> e==meet);
            if (m is null)
                return NotFound();
            m.Hour = meet.Hour;
            m.Durationofmeeting1 = meet.Durationofmeeting1;
            return NoContent();
        }

        // DELETE api/<MeetController>/5
        [HttpDelete("{id}")]
        public void Delete(Meeting meet)
        {
            meeting.Add(meet);
        }
    }
}
