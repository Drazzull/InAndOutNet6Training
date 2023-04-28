using Microsoft.AspNetCore.Mvc;

namespace InAndOutNet6Training.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}