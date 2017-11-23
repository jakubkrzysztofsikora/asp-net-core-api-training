using System;

namespace LunchService.Models
{
    public class DishToMeal
    {
        public Guid DishToMealId { get; set; }
        public Guid DishId { get; set; }
        public Guid MealId { get; set; }
        public Dish Dish { get; set; }
        public Meal Meal { get; set; }
    }
}
