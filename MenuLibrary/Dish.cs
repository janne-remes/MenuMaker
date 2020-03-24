using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLibrary
{
    public class Dish
    {
        public int menuID { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public double price { get; set; }

        // Onko tarpeellinen Dish-luokassa?
        //public DishCategory dishCategory { get; set; }

        public MenuType menuType { get; set; }

        public DishMainCharacter DishMainCharacter { get; set; }

        public FoodLimitation foodLimitation { get; set; }
    }
}
