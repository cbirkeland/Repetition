﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VueLab.UI.Models;

namespace VueLab.UI.Controllers
{
    [Route("products")]
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new List<Product>
            {
                new Product {Name = "Skiftnyckel", Quantity = 5},
                new Product {Name = "Hammare", Quantity = 10},
                new Product {Name = "Såg", Quantity = 0}

            });
        }

    }
}
