﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShoesStore.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                null,
                "",
                new { controller = "ShopProducts", action = "List", 
                    category = (string)null, page = 1 },
                new { page = @"\d+" });


            routes.MapRoute(
                null,
                "Strona{page}",
                new { controller = "ShopProducts", action = "List", category = (string)null},
                new { page = @"\d+" });

            routes.MapRoute(
                name: null,
                url: "{category}",
                defaults: new { controller = "ShopProducts", action = "List", page  = 1 });

            routes.MapRoute(
                null,
                "{category}/Strona{page}",
                new { controller = "ShopProducts", action = "List" },
                new { page = @"\d+" });

            routes.MapRoute(
                "Default",
                "{controller}/{action}",
                new { controller = "ShopProducts", action = "List"});
        }
    }
}
