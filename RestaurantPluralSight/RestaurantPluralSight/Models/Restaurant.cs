using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestaurantPluralSight.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Display(Name="Fullständigt namn")]
        [Required, MaxLength(80)]
        public string Name { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }


        public CuisineType Cuisine { get; set; }

    }

}
