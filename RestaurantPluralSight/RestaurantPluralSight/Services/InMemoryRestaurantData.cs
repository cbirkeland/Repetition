using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantPluralSight.Models;

namespace RestaurantPluralSight.Services
{
    //public class InMemoryRestaurantData : IRestaurantData
    //{
    //    public InMemoryRestaurantData()
    //    {
    //        _restaurants = new List<Restaurant>
    //        {
    //            new Restaurant {Id = 1, Name = "Christian B", EmailAddress = "Blabla@hotmail.com", PhoneNumber = "0737248293"},
    //            new Restaurant {Id = 2, Name = "Bengan", EmailAddress = "Blabdla@hotmail.com", PhoneNumber = "0737238293"},
    //            new Restaurant {Id = 3, Name = "Gurra D", EmailAddress = "Bldsabla@hotmail.com", PhoneNumber = "0733548293"},

    //        };
    //    }

    //    public IEnumerable<Restaurant> GetAll()
    //    {
    //        return _restaurants.OrderBy(r => r.Name);
    //    }

    //    public Restaurant Get(int id)
    //    {
    //        return _restaurants.FirstOrDefault(r => r.Id == id);
    //    }

    //    public Restaurant Add(Restaurant restaurant)
    //    {
    //        restaurant.Id = _restaurants.Max(r => r.Id) + 1;
    //        _restaurants.Add(restaurant);
    //        return restaurant;
    //    }

    //    List<Restaurant> _restaurants;

    //}

    
}
