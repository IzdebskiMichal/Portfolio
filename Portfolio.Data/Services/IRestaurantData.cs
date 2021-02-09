using System.Collections.Generic;
using Portfolio.Data.Data;

namespace Portfolio.Data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}