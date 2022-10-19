using InAndOutNet6Training.Models;
using Microsoft.AspNetCore.Mvc;

namespace InAndOutNet6Training.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return Ok($"You have entered: {id}");
        }

        public IActionResult GetSomeData([FromQuery] string values)
        {
            return Ok($"The value: {values} is from Query string");
        }

        [HttpPost]
        public IActionResult Post([FromHeader] string parentRequestId)
        {
            return Ok($"Got a header with parentRequestId: {parentRequestId}");
        }

        [HttpPost]
        public IActionResult AddApointment([FromBody] Appointment appointment)
        {
            return Ok(appointment);
        }

        [HttpPost]
        public IActionResult SaveFile([FromForm] string fileName, [FromForm] IFormFile file)
        {
            return Ok("Success");
        }
    }
}