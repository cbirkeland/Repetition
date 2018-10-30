

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace M11_Linq.DemoLinq
{
    class Show
    {
        public string Channel { get; set; }
        public TimeSpan StartAt { get; set; }
        public string Title { get; set; }
    }

    public class Demo1
    {
        public void Run()
        {
            // 1. Läs in textfilen

            var allLines = File.ReadAllLines("DemoLinq\\tv-data.txt");

            // 2. Skapa en lista av "Show"

            var allShows = new List<Show>();

            foreach (var line in allLines)
            {
                // SVT1*22:00*Fatta Sveriges demokrati

                string[] splittedLine = line.Split('*');
                string channel = splittedLine[0];
                string time = splittedLine[1];
                string title = splittedLine[2];

                var show = new Show();

                show.Title = title;
                show.Channel = channel;
                show.StartAt = TimeSpan.Parse(time);

                allShows.Add(show);
            }

            // 3. Skriv ut info 

            // Alla programtitlar

            Header("alla titlar");

            foreach (var show in allShows)
            {
                Console.WriteLine(show.Title);
            }

            // Alla kanaler
            Header("alla kanaler");

            foreach (var show in allShows)
            {
                Console.WriteLine(show.Channel);
            }

            // Alla program som börjar senare än 21.00 (på två sätt)

            Header("program som börjar senare än kl 21");

            var laterThan21 = new List<Show>();

            foreach (var show in allShows)
            {
                if (show.StartAt.Hours >= 21)
                {
                    laterThan21.Add(show);
                }
            }

            foreach (var show in laterThan21)
            {
                WriteInfoAboutShow(show);
            }

            // Alla program som börjar senare än 21.00 (på två sätt) - med Linq

            Header("program som börjar senare än kl 21 - med Linq");

            foreach (var show in allShows.Where(show => show.StartAt.Hours >= 21))
            {
                WriteInfoAboutShow(show);
            }

            // Program från SVT1 i kronologisk ordning

            Header("program från svt i kronologisk ordning");

            foreach (var show in allShows.Where(x => x.Channel == "SVT1").OrderBy(x => x.StartAt))
            {
                WriteInfoAboutShow(show);
            }

            // ----- Extra ------------- (ej viktigt)

            // Test med en ny metod

            Header("användning av en ny metod 'WriteShows'");

            WriteShows(allShows.Where(x => x.Channel == "SVT1").OrderBy(x => x.StartAt).ToList());


            // ----- Extra ------------- (ej viktigt)

            Header("sortera en lista");

            allShows.Sort((a,b) => String.CompareOrdinal(a.Title, b.Title));

            WriteShows(allShows);

            Console.WriteLine();
        }

        private void WriteShows(List<Show> shows)
        {
            foreach (var show in shows)
            {
                WriteInfoAboutShow(show);
            }
        }

        private void Header(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + text.ToUpper() + "\n");
            Console.ResetColor();
        }

        private void WriteInfoAboutShow(Show show)
        {
            Console.WriteLine(show.Channel.PadRight(4) + " " + show.StartAt + " " + show.Title);
        }

    }
}
