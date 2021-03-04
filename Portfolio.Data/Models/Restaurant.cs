using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        //public string Moniker { get; set; }
        public CuisineType Cuisine { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
