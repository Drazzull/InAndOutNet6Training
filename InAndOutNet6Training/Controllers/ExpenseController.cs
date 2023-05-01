using InAndOutNet6Training.Data;
using InAndOutNet6Training.Models;
using Microsoft.AspNetCore.Mvc;

namespace InAndOutNet6Training.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExpenseController(ApplicationDbContext context)
        {
            _context = context;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense expense)
        {
            try
            {
                _context.Expenses.Add(expense);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        public IActionResult Index()
        {
            try
            {
                IEnumerable<Expense> expenseList = _context.Expenses;
                return View(expenseList);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}