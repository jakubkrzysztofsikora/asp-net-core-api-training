using LunchService.Models;
using Microsoft.EntityFrameworkCore;

namespace LunchService
{
    public class LunchDbContext : DbContext
    {
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishToMeal> DishToMeal { get; set; }

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
                .HasKey(dishToMeal => dishToMeal.DishToMealId);

            modelBuilder.Entity<DishToMeal>()
                .HasOne(dishToMeal => dishToMeal.Dish)
                .WithMany(dish => dish.DishToMeals)
                .HasForeignKey(dishToMeal => dishToMeal.DishId);

            modelBuilder.Entity<DishToMeal>()
                .HasOne(dishToMeal => dishToMeal.Meal)
                .WithMany(meal => meal.DishToMeals)
                .HasForeignKey(dishToMeal => dishToMeal.MealId);
        }
    }
}
