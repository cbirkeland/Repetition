using Microsoft.AspNetCore.Mvc;
using WebApiLab.Models;

namespace WebApiLab.Controllers
{
    [Route("demo3")]
    public class DemoApi3Controller : Controller
    {

        [HttpPost("AddMeeting")]
        public IActionResult AddMeeting(Meeting meeting)
        {
            if (string.IsNullOrEmpty(meeting.Name))
                return BadRequest("Namn obligatoriskt");

            return Ok($"Du vill lägga till mötet '{meeting.Name}' med agendan '{meeting.Agenda}'");
        }


        [HttpPost("AddMeetingWithAttribute")]
        public IActionResult AddMeetingWithAttribute(Meeting meeting)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok($"Du vill lägga till mötet '{meeting.Name}' med agendan '{meeting.Agenda}'");
        }
    }
}