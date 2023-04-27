using InAndOutNet6Training.Models;
using Microsoft.EntityFrameworkCore;

namespace InAndOutNet6Training.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Item>? Items { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}