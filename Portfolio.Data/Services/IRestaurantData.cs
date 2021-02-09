using System.Collections.Generic;
using Portfolio.Data.Models;

namespace Portfolio.Data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant GetRestaurantById(int id);
        void AddRestaurant(Restaurant restaurant);
    }
}