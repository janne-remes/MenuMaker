using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLibrary
{
    public class MenuCategory
    {
        public string name { get; set; }

        public string description { get; set; }

        public List<Dish> dishes { get; set; } = new List<Dish>();
    }
}
