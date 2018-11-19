using Microsoft.EntityFrameworkCore;
using RestaurantPluralSight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPluralSight.Data
{
    public class RestaurantPluralSightDbContext : DbContext
    {
        public RestaurantPluralSightDbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
