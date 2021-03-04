using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Portfolio.Data.Services;

namespace Portfolio.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder();

            //registering controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //registering api controllers
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);

            //register services
            builder.RegisterType<SqlRestaurantData>().As<IRestaurantData>().InstancePerRequest();
            builder.RegisterType<PortfolioDBContext>().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}