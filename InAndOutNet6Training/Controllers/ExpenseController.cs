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
                if (!ModelState.IsValid)
                {
                    return View(expense);
                }

                _context.Expenses.Add(expense);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        public IActionResult Delete(int? id)
        {
            try
            {
                if (id == null || id == 0)
                {
                    return NotFound();
                }
                
                var expense = _context.Expenses.Find(id);
                if (expense == null)
                {
                    return NotFound();
                }
                
                return View(expense);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            try
            {
                var expense = _context.Expenses.Find(id);
                if (expense == null)
                {
                    return NotFound();
                }

                _context.Expenses.Remove(expense);
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

        public IActionResult Update(int? id)
        {
            try
            {
                if (id == null || id == 0)
                {
                    return NotFound();
                }

                var expense = _context.Expenses.Find(id);
                if (expense == null)
                {
                    return NotFound();
                }

                return View(expense);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePost(Expense expense)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return RedirectToAction(nameof(Update), new { expense.Id });
                }

                _context.Expenses.Update(expense);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

    }
}