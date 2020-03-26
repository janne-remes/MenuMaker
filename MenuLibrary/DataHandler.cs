using System;
using System.Collections.Generic;
using System.Text;

namespace MenuLibrary
{
    public class DataHandler
    {
        public List<Dish> dishes = new List<Dish>();

        //public void fillDishesWithTestData()
        //{
        //    this.dishes.Add(new Dish("Kalakukkoa", "Savolaista perinneruokaa", 4,95));
        //}
        
        public Dish insertDish()
        {
            Console.WriteLine("\nSyötä annoksen nimi:");

            string aterianNimi = Console.ReadLine();

            Console.WriteLine("\nSyötä annoksen kuvaus:");

            string aterianKuvaus = Console.ReadLine();

            Console.WriteLine("\nSyötä annoksen hinta:");

            double aterianHinta = double.Parse(Console.ReadLine());

            Dish ateria = new Dish(aterianNimi, aterianKuvaus, aterianHinta);

            //Console.WriteLine("\n*****");
            //Console.WriteLine($"\nSyötit seuraavan annoksen\n");
            //Console.WriteLine(ateria.DishName);
            //Console.WriteLine(ateria.DishDescription);
            //Console.WriteLine($"{ateria.Price} e");

            return ateria;
        }

        public Dish addDishToList()
        {
            var ateria = insertDish();

            this.dishes.Add(ateria);

            Console.WriteLine("\nAnnos on lisätty.");

            return ateria;
        }

        public void printDishesList()
        {
            if (this.dishes.Count == 0)
            {
                Console.WriteLine("Ei annoksia listalla");
            }

            //int i = 1;

            foreach (Dish dish in this.dishes)
            {
                Console.WriteLine($"{dish.DishName} | {dish.DishDescription} | {dish.Price}");
            }
        }

        public MenuCategory insertMenuCategory()
        {
            return null;
        }
    }
}
