using System;
using MenuLibrary;

namespace MenuMakerConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var dh = new DataHandler();
            
            Console.WriteLine("MENU MAKER");

            Console.WriteLine("- - - - - -");

            dh.addDishToList();

            Console.WriteLine("\nPaina mitä tahansa näppäintä jatkaaksesi");

            Console.ReadKey();

            Console.Clear();

            dh.addDishToList();

            Console.Clear();

            dh.printDishesList();

            Console.ReadKey();


        }
    }
}
