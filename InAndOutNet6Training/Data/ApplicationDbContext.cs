using InAndOutNet6Training.Models;
using Microsoft.EntityFrameworkCore;

namespace InAndOutNet6Training.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Expense> Expenses => Set<Expense>();
        public DbSet<ExpenseCategory> ExpenseCategories => Set<ExpenseCategory>();
        public DbSet<Item> Items => Set<Item>();
    }
}