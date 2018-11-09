using Microsoft.AspNetCore.Mvc;
using RestaurantPluralSight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPluralSight.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var model = new Restaurant { Id = 1, Name = "Scott's Pizza Place" };
            return View(model); 
        }
    }
}
