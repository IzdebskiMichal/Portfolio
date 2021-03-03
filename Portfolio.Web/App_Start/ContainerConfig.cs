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
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;

            //registering api controllers
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            //registering controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //register services
            builder.RegisterType<SqlRestaurantData>().As<IRestaurantData>().InstancePerRequest();
            builder.RegisterType<PortfolioDBContext>().InstancePerRequest();

            //set up config
            builder.RegisterWebApiFilterProvider(config);
            builder.RegisterWebApiModelBinderProvider();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}