using LunchService.Models;
using Microsoft.EntityFrameworkCore;

namespace LunchService
{
    public class LunchDbContext : DbContext
    {
        public DbSet<Meal> Meals { get; set; }

        public LunchDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meal>()
                .HasKey(meal => meal.Id);
        }
    }
}
