using System;
using System.Collections.Generic;

namespace DemoWithOneProject2
{
    class Program
    {
        static void Main()
        {
            // Rensa databasen + lägg in några frukter kopplade till olika kategorier

            ClearAndInitDatabase();

            // Visa alla frukter

            DisplayAllFruits();

            // Visa bara skenfrukter

            DisplayJustSkenfrukter();


            Console.ReadKey();
        }

        private static void DisplayJustSkenfrukter()
        {
            var dataAccess = new DataAccess();
            List<Fruit> fruits = dataAccess.GetFruitsInCategory("Skenfrukt");
            Console.WriteLine();
            Console.WriteLine("SKENFRUKTER");
            Console.WriteLine();
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit.Name);
            }
        }

        private static void DisplayAllFruits()
        {
            var dataAccess = new DataAccess();
            foreach (Fruit x in dataAccess.GetAll())
            {
                Console.WriteLine(x.Id.ToString().PadRight(5) + x.Name.PadRight(20) +
                                  x.Price.ToString().PadRight(10) + x.Category.Name.PadRight(10));
            };
        }

        private static void ClearAndInitDatabase()
        {
            var dataAccess = new DataAccess();
            dataAccess.ClearDatabase();
            dataAccess.AddCategoriesAndFruits();
            dataAccess.SaveChanges();
        }
    }
}


 
