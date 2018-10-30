using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DemoWithOneProject2
{
    public class DataAccess : IDisposable
    {
        private readonly FruitContext _context;

        public DataAccess()
        {
            _context = new FruitContext();
        }

        public void ClearDatabase()
        {
            foreach (var fruit in _context.FruitCategories)
            {
                _context.Remove(fruit);
            }

            foreach (var fruit in _context.Fruits)
            {
                _context.Remove(fruit);
            }
        }

        public void AddCategoriesAndFruits()
        {
            var skenfrukt = new FruitCategory { Name = "Skenfrukt" };
            var torrÄkta = new FruitCategory { Name = "Torr äkta frukt" };
            var saftigÄkta = new FruitCategory { Name = "Saftig äkta frukt" };

            _context.FruitCategories.Add(skenfrukt);
            _context.FruitCategories.Add(torrÄkta);
            _context.FruitCategories.Add(saftigÄkta);

            AddFruit("Ananas", skenfrukt);
            AddFruit("Nypon", skenfrukt, 100);
            AddFruit("Smultron", skenfrukt);
            AddFruit("Päron", skenfrukt);
            AddFruit("Äpple", skenfrukt);

            AddFruit("Körsbär", saftigÄkta);
            AddFruit("Mandel", saftigÄkta);
            AddFruit("Persika", saftigÄkta);
            AddFruit("Plommon", saftigÄkta);

            AddFruit("Ärtor", torrÄkta);
            AddFruit("Kikärtor", torrÄkta);
            AddFruit("Bönor", torrÄkta);

        }

        private void AddFruit(string name, FruitCategory category, decimal? price=null)
        {
            _context.Fruits.Add(new Fruit { Name = name, Category = category, Price = price});
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
            
        }

        public List<Fruit> GetAll()
        {
            return _context.Fruits.Include(x=>x.Category).ToList();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public List<Fruit> GetFruitsInCategory(string categoryName)
        {

            return _context.FruitCategories
                       .Include(x => x.Fruits)
                       .SingleOrDefault(x => x.Name == categoryName)
                       ?.Fruits.ToList() ?? new List<Fruit>();
        }
    }
}
