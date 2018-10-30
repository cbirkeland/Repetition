using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DemoWithOneProject3
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
            foreach (var category in _context.FruitCategories)
            {
                _context.Remove(category);
            }

            foreach (var fruit in _context.Fruits)
            {
                _context.Remove(fruit);
            }

            foreach (var basket in _context.Baskets)
            {
                _context.Remove(basket);
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
            var nypon = AddFruit("Nypon", skenfrukt, 100);
            AddFruit("Smultron", skenfrukt);
            AddFruit("Päron", skenfrukt);
            AddFruit("Äpple", skenfrukt);

            AddFruit("Körsbär", saftigÄkta);
            AddFruit("Mandel", saftigÄkta);
            var persika = AddFruit("Persika", saftigÄkta);
            var plommon = AddFruit("Plommon", saftigÄkta);

            AddFruit("Ärtor", torrÄkta);
            AddFruit("Kikärtor", torrÄkta);
            AddFruit("Bönor", torrÄkta);

            var b1 = new Basket();
            b1.Name = "Min shoppingkorg";

            b1.FruitInBaskets = new List<FruitInBasket>();

            b1.FruitInBaskets.Add(new FruitInBasket
            {
                Fruit = nypon
            });

            b1.FruitInBaskets.Add(new FruitInBasket
            {
                Fruit = persika
            });
            b1.FruitInBaskets.Add(new FruitInBasket
            {
                Fruit = plommon
            });

            var b2 = new Basket();
            b2.Name = "Mina shoppingkorg med plommon";
            b2.FruitInBaskets = new List<FruitInBasket>();

            b2.FruitInBaskets.Add(new FruitInBasket
            {
                Fruit = plommon
            });

            _context.Baskets.Add(b1);
            _context.Baskets.Add(b2);

        }

        private Fruit AddFruit(string name, FruitCategory category, decimal? price=null)
        {
            var newFruit = new Fruit {Name = name, Category = category, Price = price};
            _context.Fruits.Add(newFruit);
            return newFruit;
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

        public List<Basket> GetAllBaskets()
        {
            return _context.Baskets.ToList();
        }

        public List<Fruit> GetAllFruitsInBasket(int basketId)
        {
            var basket = _context
                .Baskets
                .Include(x=>x.FruitInBaskets)
                .ThenInclude(x=>x.Fruit)
                .Single(b => b.Id == basketId);

            return basket.FruitInBaskets.Select(x => x.Fruit).ToList();
        }
    }
}
