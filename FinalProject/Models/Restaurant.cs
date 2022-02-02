using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Restaurant  
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string CuisineType { get; set; }
        public bool FullyMeatless { get; set; }
    }
}
