using InAndOutNet6Training.Data;
using InAndOutNet6Training.Models;
using Microsoft.AspNetCore.Mvc;

namespace InAndOutNet6Training.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            try
            {
                IEnumerable<Item> itemList = _context.Items;
                return View(itemList);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        public IActionResult Create()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}