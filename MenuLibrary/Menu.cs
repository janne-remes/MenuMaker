using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLibrary
{
    public class Menu
    {
        public string name { get; set; }

        public string description { get; set; }

        public List<MenuCategory> menuCategories { get; set; } = new List<MenuCategory>();
    }
}
