using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Ange namn på rum");
            Console.ForegroundColor = ConsoleColor.Gray;
            string input = Console.ReadLine();
            string[] roomArray = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            
            var allRooms = new List<Room>();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in roomArray)
            {
                var room = new Room();
                string[] pair = item.Trim().Split(' ');
                string nameOfRoom = pair[0];
                int sizeOfRoom = int.Parse(pair[1].Replace("m2", ""));

                room.Name = nameOfRoom;
                room.Size = sizeOfRoom;

                allRooms.Add(room);

            }

            int rownumber = 1;
            foreach (var room in allRooms)
            {
                Console.WriteLine($"* Rumnamn {rownumber}: {room.Name}");
            }

            Console.WriteLine();
            Room biggestroom = allRooms.OrderByDescending(x => x.Size).First();
            Console.WriteLine($"* Det största rummet är {biggestroom.Name} med {biggestroom.Size}m2");


        }
    }
}
