using System;
using MenuLibrary;

namespace MenuMakerConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU MAKER");

            Console.WriteLine("- - - - - -");

            Dish ateria = new Dish();

            Console.WriteLine("Syötä aterian nimi:");

            ateria.DishName = Console.ReadLine();

            Console.WriteLine($"Aterian nimi on: {ateria.DishName}");




        }
    }
}
