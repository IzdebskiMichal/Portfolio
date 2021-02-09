using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.Data.Data;

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
    }
}
