using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.Data.Models;

namespace Portfolio.Data.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly RestaurantsDbContext _db;

        public SqlRestaurantData(RestaurantsDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _db.Restaurants.OrderBy(r => r.Name);
        }

        public Restaurant GetRestaurantById(int id)
        {
            return _db.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public void AddRestaurant(Restaurant restaurant)
        {
            _db.Restaurants.Add(restaurant);
            _db.SaveChanges();
        }

        public void EditRestaurant(Restaurant restaurant)
        {
            var entry = _db.Entry(restaurant);
            entry.State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
