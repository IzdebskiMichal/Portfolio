﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Portfolio.Web.API.Controllers
{
    public class RestaurantsController : ApiController
    {
        public object Get()
        {
            return new {Name = "Michal", Ocupation = "Junior Software Engineer"};
        }
    }
}