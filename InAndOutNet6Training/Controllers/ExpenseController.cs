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