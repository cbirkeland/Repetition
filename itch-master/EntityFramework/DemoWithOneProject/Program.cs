using System;

namespace DemoWithOneProject
{
    class Program
    {
        static void Main()
        {
            FruitContext _context = new FruitContext();

            //_context.Database.EnsureDeleted();
            //_context.Database.EnsureCreated(); // Använder inte migrationer för att uppdatera databasen. Kan inte senare uppdatera databasen mha migrationer

            _context.Fruits.Add(new Fruit { Name = "Banan" });
            _context.SaveChanges();

            foreach (Fruit x in _context.Fruits)
            {
                Console.WriteLine(x.Id + "  " + x.Name);
            }

            Console.ReadKey();
        }
    }
}
