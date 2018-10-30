
// Vardagsrum 40m2 | Toa 5m2 | Kök 6m2 | Hall 10m2

using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint02.OscarOlsson.Level2
{
    public class App
    {
        public void Run()
        {
            // 1. Läs in sträng

            Console.Write("Ange namn på rum: ");
            string input = Console.ReadLine();

            Console.WriteLine();

            // 2. Omvandla strängen till en lista av strängar
            string[] roomsArray = input.Split(new []{'|'}, StringSplitOptions.RemoveEmptyEntries);

            // 3. Skapa en lista av "Room"
            var allRooms = new List<Room>();

            foreach (string roomString in roomsArray)
            {
                var room = new Room();
                string[] pair = roomString.Trim().Split(' ');
                string nameOfTheRoom = pair[0];
                string sizeOfRoom = pair[1].Replace("m2", "");

                room.Name = nameOfTheRoom;
                room.Size = int.Parse(sizeOfRoom);

                allRooms.Add(room);
            }

            // 4 .Skriv ut alla rum

            int rowNumber = 1;
            foreach (var room in allRooms)
            {
                Console.WriteLine("Rum " + rowNumber + ": " +  room.Name);
                rowNumber++;
            }

            // 5. Skriv info om största rummet (om det finns något rum)

            if (allRooms.Count > 0)
            {
                // ---- Alternativ (med två variabler som håller reda på det största rummet)

                //string biggestRoomName = "";
                //int biggestRoomSize = 0;

                //foreach (var room in allRooms)
                //{
                //    if (room.Size > biggestRoomSize)
                //    {
                //        biggestRoomSize = room.Size;
                //        biggestRoomName = room.Name;
                //    }
                //}

                //Console.WriteLine("Det största rummet är " + biggestRoomName + " på " + biggestRoomSize + " m2");

                // ---- Alternativ (samma som ovan men med ett Room-objekt)

                //Room biggestRoom = allRooms[0];

                //foreach (var room in allRooms)
                //{
                //    if (room.Size > biggestRoom.Size)
                //    {
                //        biggestRoom.Size = room.Size;
                //        biggestRoom.Name = room.Name;
                //    }
                //}

                //Console.WriteLine("Det största rummet är " + biggestRoom.Name + " på " + biggestRoom.Size + " m2");

                // ---- Alternativ (med LINQ)

                Room biggestRoom = allRooms.OrderByDescending(x => x.Size).First();
                Console.WriteLine("Det största rummet är " + biggestRoom.Name + " på " + biggestRoom.Size + " m2");
            }

        }


    }
}
