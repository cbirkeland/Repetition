using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint6
{
    class Program
    {
        private static SpaceContext context = new SpaceContext();

        static void Main(string[] args)
        {
            RecreateDatabase();

            AddSpaceship("USS Enterprise");
            AddSpaceship("Millennium Falcon");
            AddSpaceship("Cylon Raider");

            List<SpaceShip> list = GetAllSpaceships();
            DisplaySpaceships(list);


        }

        private static void RecreateDatabase()
        {
            using (var context = new SpaceContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }

        private static void DisplaySpaceships(List<SpaceShip> list)
        {
            foreach (SpaceShip ship in list)
            {
                Console.WriteLine(ship.Name);
            }
        }

        private static List<SpaceShip> GetAllSpaceships()
        {
            return context.SpaceShip.ToList();
        }

        private static void AddSpaceship(string name)
        {
            var spaceship = new SpaceShip { Name = name };
            using (var context = new SpaceContext())
            {
                context.SpaceShip.Add(spaceship);
                context.SaveChanges();
            }
        }

        
    }
}
