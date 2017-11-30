using System;
using System.Collections.Generic;
using System.Linq;

namespace LunchService.Models
{
    public class Dish
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DishToMeal> DishToMeals { get; set; }
    }
}
