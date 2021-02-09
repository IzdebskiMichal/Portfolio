using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Data.Models;
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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Restaurant restaurant)
        {
            if (restaurant != null)
            {
                _db.AddRestaurant(restaurant);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var model = _db.GetRestaurantById(id);
            return View(model);
        }
    }
}