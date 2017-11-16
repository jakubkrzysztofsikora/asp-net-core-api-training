﻿using System;
using System.Collections.Generic;

namespace LunchService.Models
{
    public class Meal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<DishToMeal> DishToMeals { get; set; }
    }
}
