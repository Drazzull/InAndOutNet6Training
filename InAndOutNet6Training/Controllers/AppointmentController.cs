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
    }
}