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

            modelBuilder.Entity<Dish>()
                .HasKey(dish => dish.Id);

            modelBuilder.Entity<DishToMeal>()
                .HasKey(dishToMeal => new
                {
                    dishToMeal.DishId,
                    dishToMeal.MealId
                });

            modelBuilder.Entity<DishToMeal>()
                .HasOne(dishToMeal => dishToMeal.Dish)
                .WithMany(dish => dish.DishToMeals)
                .HasForeignKey(dishToMeal => dishToMeal.DishId);

            modelBuilder.Entity<DishToMeal>()
                .HasOne(dishToMeal => dishToMeal.Meal)
                .WithMany(meal => meal.DishToMeals)
                .HasForeignKey(dishToMeal => dishToMeal.MealId);
        }

        public DbSet<LunchService.Models.Dish> Dish { get; set; }
    }
}
