using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Data.Services;

namespace Portfolio.Web.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IRestaurantData _db;

        public RestaurantsController(IRestaurantData db)
        {
            _db = db;
        }

        // GET: Restaurants
        public ActionResult Index()
        {
            var model = _db.GetAll();
            return View(model);
        }
    }
}