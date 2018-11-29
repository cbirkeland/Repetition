using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantPluralSight.Data;
using RestaurantPluralSight.Models;

namespace RestaurantPluralSight.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private RestaurantPluralSightDbContext _context;

        public SqlRestaurantData(RestaurantPluralSightDbContext context)
        {
            _context = context;
        }

        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
            return restaurant;
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Update(Restaurant restaurant)
        {
            _context.Attach(restaurant).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return restaurant;
        }
    }
}
