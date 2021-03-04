using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Portfolio.Data.Models;
using Portfolio.Data.Services;

namespace Portfolio.Web.API.Controllers
{
    public class RestaurantsController : ApiController
    {
        private readonly IRestaurantData _db;

        public RestaurantsController(IRestaurantData db)
        {
            _db = db;
        }

        public IHttpActionResult Get()
        {
            var result = _db.GetAll();



            return Ok(result);
        }
    }
}
