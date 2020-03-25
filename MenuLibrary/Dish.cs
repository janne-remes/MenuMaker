using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLibrary
{
    public class Dish
    {
        //public int menuID { get; set; }

        private string dishName;
        private string dishDescription;
        public double price { get; set; }
        public DishMainCharacter DishMainCharacter { get; set; }
        public FoodLimitation foodLimitation { get; set; }

        // Onko tarpeellisia Dish-luokassa?
        //public DishCategory dishCategory { get; set; }

        //public MenuType menuType { get; set; }


        public string DishName
        {
            get
            {
                return dishName;
            }

            set
            {
                if (value != "")
                {
                    dishName = value;
                }
            }
        }
    }
}
