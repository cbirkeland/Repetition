﻿using OdeToFood.Models;
using System.Collections.Generic;

namespace OdeToFood.ViewModels
{
    public class RestaurantIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string Hello { get; set; }
        public string SomeCountMessage { get; set; }
        public string SomethingFromGoogle { get; set; }
    }
}
