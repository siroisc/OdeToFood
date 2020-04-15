using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Data.Models
{
    // Model/Entity that is persisted into the database.
    public class Restaurant
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name="Type of Food")]
        public CuisineType Cuisine { get; set; }
    }
}
