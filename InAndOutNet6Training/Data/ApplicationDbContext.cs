using InAndOutNet6Training.Models;
using Microsoft.EntityFrameworkCore;

namespace InAndOutNet6Training.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Item> Items => Set<Item>();
        public DbSet<Expense> Expenses => Set<Expense>();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}