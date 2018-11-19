using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantPluralSight.Models;
using RestaurantPluralSight.Services;

namespace RestaurantPluralSight.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        private IRestaurantData _restaurantData;
        public Restaurant Restaurant { get; set; }

        public EditModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public IActionResult OnGet(int id)
        {
            Restaurant = _restaurantData.Get(id);

            if (Restaurant == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return Page();
        }
    }
}