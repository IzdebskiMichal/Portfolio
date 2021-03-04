using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Portfolio.Data.Models;
using Portfolio.Web.Models;

namespace Portfolio.Web.Mappers
{
    class RestaurantMappingProfile : Profile
    {
        public RestaurantMappingProfile()
        {
            CreateMap<Restaurant, RestaurantModel>();
        }
    }
}
