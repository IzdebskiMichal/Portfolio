using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.Data.Models;

namespace Portfolio.Data.Services
{
    public class InMemoryRestaurantDB : IRestaurantData
    {
        List<Restaurant> _restaurants;

        public InMemoryRestaurantDB()
        {
            _restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Michal's Pizza", Cuisine = CuisineType.Italian},
                new Restaurant { Id = 2, Name = "French Restaurant", Cuisine = CuisineType.French},
                new Restaurant { Id = 3, Name = "Mango Grove", Cuisine = CuisineType.Indian},
                new Restaurant { Id = 4, Name = "Sushi Restaurant", Cuisine = CuisineType.Japanese},
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r=>r.Name);
        }

        public Restaurant GetRestaurantById(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public void AddRestaurant(Restaurant restaurant)
        {
            if (restaurant !=null)
            {
            _restaurants.Add(restaurant);
            }
        }
    }
}
