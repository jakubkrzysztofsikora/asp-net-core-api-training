using System.Collections.Generic;
using LunchService.Models;

namespace LunchService.Dtos
{
    public class MealWithDishesDto
    {
        public string Name { get; set; }
        public IEnumerable<Dish> Dishes { get; set; }
    }
}
