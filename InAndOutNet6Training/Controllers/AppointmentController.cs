using Microsoft.AspNetCore.Mvc;

namespace InAndOutNet6Training.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            string todaysDate = DateTime.Now.ToShortDateString();
            return Ok(todaysDate);
            //return View();
        }
    }
}
