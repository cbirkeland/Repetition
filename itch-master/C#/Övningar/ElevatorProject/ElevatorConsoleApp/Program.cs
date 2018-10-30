using System;
using ElevatorProject;

namespace ElevatorConsoleApp
{
    class Program
    {
        // todo: metoder för utskrift
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            // Test av Kalle

            Header("SKAPAR HISSEN KALLE");
            var e1 = new Elevator("Kalle", -2, 10, 5, 2);
            Console.WriteLine("     " + e1.Report());
            Info("Signal till Kalle att åka upp en våning");
            e1.GoUp();
            Console.WriteLine("     " + e1.Report());

            Info("Signal till Kalle att åka upp en våning");
            e1.GoUp();
            Console.WriteLine("     " + e1.Report());

            Info("Signal till Kalle att åka upp en våning");
            e1.GoUp();
            Console.WriteLine("     " + e1.Report());

            // Test av Lisa (hissen är redan på lägsta nivå så kommer inte åka nånstans)

            Header("SKAPAR HISSEN LISA");
            var e2 = new Elevator("Lisa", 5, 8);
            Console.WriteLine("     " + e2.Report());
            Info("Signal till Lisa att åka ner en våning");
            e2.GoDown();
            Console.WriteLine("     " + e2.Report());

            // Test av Johan som ska faila

            try
            {

                Header("SKAPAR HISSEN JOHAN");
                var e3 = new Elevator("Johan", 500, 5);
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"     Något gick snett med hissen Johan: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
            }
        }

        private static void Header(string text)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        private static void Info(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("     " + text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
