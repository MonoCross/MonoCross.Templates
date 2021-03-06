﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace $safeprojectname$
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.RouteExistingFiles = false;
            routes.IgnoreRoute("WebApp/{*pathInfo}");
            routes.Ignore("favicon.ico");
            routes.MapRoute(
                name: "",
                url: "{*mapUri}",
                defaults: new { controller = "App", action = "Render", id = UrlParameter.Optional });
        }
    }
}
