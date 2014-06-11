using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace Web
{
    public class CastleConfig
    {
        public static IWindsorContainer Container; 

        public static void Bootstrap(HttpConfiguration configuration)
        {
            Container = new WindsorContainer();
            Container.Install(FromAssembly.This());
        }
    }

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();
        }
    }
}
