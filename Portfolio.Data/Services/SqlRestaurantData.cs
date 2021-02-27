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
        private readonly PortfolioDBContext _db;

        public SqlRestaurantData(PortfolioDBContext db)
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

        public void DeleteRestaurant(int id)
        {
            var restaurant = _db.Restaurants.Find(id);

            if (restaurant == null) return;

            _db.Restaurants.Remove(restaurant);
            _db.SaveChanges();
        }
    }
}
