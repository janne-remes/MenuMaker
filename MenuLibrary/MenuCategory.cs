using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLibrary
{
    public class MenuCategory
    {
        public string name { get; set; }

        public string description { get; set; }

        public List<Dish> dishes = new List<Dish>();

        public MenuCategory()
        {

        }

        public MenuCategory(string name, string description, List<Dish> dishes)
        {
            this.name = name;
            this.description = description;
            this.dishes = dishes;
        }
    }
}
