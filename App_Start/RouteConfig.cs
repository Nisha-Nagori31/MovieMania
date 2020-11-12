using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MovieMania
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //*routes should be from more specific to general

            //custom route: Realese date movies
            //routes.MapRoute("MoviesByReleaseDate", "movies/released/{year}/{month}",
            //    new { controller = "Movies", action = "ByReleaseDate" }, 
            //    new { year = @"\d{4}", month = @"\d{2}" });

            //*we will use custom attribute using attribute routing, as custom routes will fill up route file

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapMvcAttributeRoutes();  //*enabling Attribute Routing
        }
    }
}
