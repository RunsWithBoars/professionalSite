﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DustinCrawford.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Navigation", action = "Home", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Catchall",
                url: "{*anything}",
                defaults: new { controller = "Error", action = "Missing" }
            );
        }
    }
}
