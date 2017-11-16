using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchService.Models
{
    public class DishToMeal
    {
        public Guid DishId { get; set; }
        public Guid MealId { get; set; }
        public Dish Dish { get; set; }
        public Meal Meal { get; set; }
    }
}
