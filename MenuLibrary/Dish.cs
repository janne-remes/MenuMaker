using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLibrary
{
    public class Dish
    {
        private string dishName;
        private string dishDescription;
        private double price;

        public DishMainCharacter DishMainCharacter { get; set; }
        public FoodLimitation foodLimitation { get; set; }

        public Dish()
        {

        }

        public Dish(string dishName, string dishDescription, double price)
        {
            this.dishName = dishName;
            this.dishDescription = dishDescription;
            this.price = price;
        }

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

        public string DishDescription
        {
            get
            {
                return dishDescription;
            }

            set
            {
                if (value != "")
                {
                    dishDescription = value;
                }
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }
    }
}
