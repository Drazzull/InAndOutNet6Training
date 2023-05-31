using InAndOutNet6Training.Data;
using InAndOutNet6Training.Models;
using Microsoft.AspNetCore.Mvc;

namespace InAndOutNet6Training.Controllers
{
    public class ExpenseCategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExpenseCategoryController(ApplicationDbContext context)
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
        public IActionResult Create(ExpenseCategory expenseCategory)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(expenseCategory);
                }

                _context.ExpenseCategories.Add(expenseCategory);
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

                var expenseCategory = _context.ExpenseCategories.Find(id);
                if (expenseCategory == null)
                {
                    return NotFound();
                }

                return View(expenseCategory);
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
                var expenseCategory = _context.ExpenseCategories.Find(id);
                if (expenseCategory == null)
                {
                    return NotFound();
                }

                _context.ExpenseCategories.Remove(expenseCategory);
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
                IEnumerable<ExpenseCategory> expenseCategoryList = _context.ExpenseCategories;
                return View(expenseCategoryList);
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

                var expenseCategory = _context.ExpenseCategories.Find(id);
                if (expenseCategory == null)
                {
                    return NotFound();
                }

                return View(expenseCategory);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePost(ExpenseCategory expenseCategory)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return RedirectToAction(nameof(Update), new { expenseCategory.Id });
                }

                _context.ExpenseCategories.Update(expenseCategory);
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