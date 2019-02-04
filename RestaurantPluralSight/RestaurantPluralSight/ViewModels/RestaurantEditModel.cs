using RestaurantPluralSight.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPluralSight.ViewModels
{
    public class RestaurantEditModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public string Cuisine { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }




    }
}
