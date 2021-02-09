using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Data.Services;

namespace Portfolio.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _db;

        public HomeController()
        {
            _db = new InMemoryRestaurantDB();
        }
        public ActionResult Index()
        {
            var model = _db.GetAll();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}