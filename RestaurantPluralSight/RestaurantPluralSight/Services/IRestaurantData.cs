﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantPluralSight.Models;

namespace RestaurantPluralSight.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant restaurant);
        Restaurant Update(Restaurant restaurant);
            
    }
}
