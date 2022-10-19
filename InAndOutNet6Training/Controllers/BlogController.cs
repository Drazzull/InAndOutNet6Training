using Microsoft.AspNetCore.Mvc;

namespace InAndOutNet6Training.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Article()
        {
            return Ok("Action of Blog controller is called.");
        }

        [Route("Blog")]
        [Route("Blog/Index")]
        [Route("Blog/Index/{id?}")]
        public IActionResult AnyActionName(int id)
        {
            return Ok("Index called");
        }
    }
}
