using System.Collections.Generic;
using System.Threading.Tasks;
using Portfolio.Data.Models;

namespace Portfolio.Data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant GetRestaurantById(int id);
        void AddRestaurant(Restaurant restaurant);
        void EditRestaurant(Restaurant restaurant);
        void DeleteRestaurant(int id);
        IEnumerable<Employee> GetEmployeesFromRestaurant(int id);
    }
}