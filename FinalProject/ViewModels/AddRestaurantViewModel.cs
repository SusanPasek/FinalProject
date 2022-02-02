using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.ViewModels
{
    public class AddRestaurantViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 30 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Restaurant can only have one location")]
        public string Location { get; set; }

        [Required]
        public string CuisineType { get; set; }

    }
}
