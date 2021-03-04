using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Models
{
    public class RestaurantModel
    {
        [Required]
        public string Name { get; set; }
        public string Moniker { get; set; }
    }
}