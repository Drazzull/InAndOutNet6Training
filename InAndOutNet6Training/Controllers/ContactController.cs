using Microsoft.AspNetCore.Mvc;

namespace InAndOutNet6Training.Controllers
{
    [Route("Admin/[controller]")]
    public class ContactController : Controller
    {
        [Route("Main")]
        public IActionResult Index()
        {
            return Ok("Action main called");
        }

        [Route("Details/{id?}")]
        public IActionResult SomeActionName(int id)
        {
            return Ok($"Action Details called with id: {id}");
        }
    }
}
