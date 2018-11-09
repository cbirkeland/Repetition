using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange kommando: ");
            string numbers = Console.ReadLine();

            // Omvandla string till lista
            List<string> myList = numbers.Split('-').ToList();

            // ELLER
            // List<string> myList = new List<string>();
            // numbers.Split('-');
            // mylist.Add(numbers);

            foreach (string item in myList)    // Kör foreach för att kunna omvandla string(item) till int. 
            {
                int star = int.Parse(item);

                for (int i = 0; i <= star; i++)        // ÄNDRA i = 0 till i = 1
                {
                    for (int t = 0; t <= i; t++)       // ÄNDRA t = + till t = 1
                    {
                        Console.Write("*");             // DEN INRE FOR-LOOPEN BYGGER PÅ BREDDEN. SE TECKNET. 
                    }
                    Console.WriteLine("");

                }
            }
        }
    }
}
