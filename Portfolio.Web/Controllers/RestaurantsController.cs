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
        [ValidateAntiForgeryToken]
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
            //todo display employees
            var model = _db.GetRestaurantById(id);
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = _db.GetRestaurantById(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _db.EditRestaurant(restaurant);
                return RedirectToAction("Details", new {id = restaurant.Id});
            }

            return View(restaurant);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = _db.GetRestaurantById(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection form)
        {
            _db.DeleteRestaurant(id);
            return RedirectToAction("Index");
        }

        //todo add a controller for employees. In it's controller allow user to remove, add, edit employes in a specific restaurant.
        public ActionResult Employees(Restaurant restaurant, int id)
        {
            var model = _db.GetEmployeesFromRestaurant(id);
            if (model == null) 
                return RedirectToAction("CreateEmployee", new {id = restaurant.Id}); //todo add CreateEmployee action.
            return View(model); //todo add a view for this action.
            throw new NotImplementedException();
        }
    }
}