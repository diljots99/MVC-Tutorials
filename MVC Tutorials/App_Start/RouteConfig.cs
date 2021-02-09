﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Tutorials
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ModelBinding",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
            name: "ViewTo",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "ViewTo", action = "Index", id = UrlParameter.Optional }
        );
            routes.MapRoute(
               name: "Demonstration",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Demonstration", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
