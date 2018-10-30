using CommonStuff;
using System;
using System.Collections.Generic;

namespace M12_Interfaces
{
    public class InterfaceLab1
    {
        ConsoleHelper ch = new ConsoleHelper();

        public void Run()
        {
            ch.InitConsole();

            string[] rockstarsArray = { "Jim Morrison", "Ozzy Osborne",  "David Bowie", "Freddie Mercury"};
            List<string> rockstarsList = new List<string> { "Jim Morrison", "Ozzy Osborne", "David Bowie", "Freddie Mercury" };

            DisplayArrayOfRockStars("My rockstars: (array)", rockstarsArray);
            DisplayListOfRockStars("My rockstars: (list)", rockstarsList);

            DisplayRockStars("My rockstars: (ienumerable)", rockstarsArray);
            DisplayRockStars("My rockstars: (ienumerable)", rockstarsList);

        }

        private void DisplayArrayOfRockStars(string header, string[] rockstars)
        {
            
            Console.WriteLine(header);
            foreach (string rockstar in rockstars)
            {
                ch.WriteDark($"* {rockstar}");
            }
            Console.WriteLine();
        }

        private void DisplayListOfRockStars(string header, List<string> rockstars)
        {
            
            Console.WriteLine(header);
            foreach (string rockstar in rockstars)
            {
                ch.WriteDark($"* {rockstar}");
            }
            Console.WriteLine();
        }

        private void DisplayRockStars(string header, IEnumerable<string> rockstars)
        {
           
            Console.WriteLine(header);
            foreach (string rockstar in rockstars)
            {
                ch.WriteDark($"* {rockstar}");
            }
            Console.WriteLine();
        }
    }
}
