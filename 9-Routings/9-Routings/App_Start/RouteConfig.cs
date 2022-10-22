using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _9_Routings
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //custom routes
            routes.MapRoute(
            name: "MyCustomRote", // my custom route name
            url: "MyRoute/{controller}/{action}/{id}",  //url pattern for my custom route
            defaults: new { controller = "HomeForCustomRoute", action = "Index", id = UrlParameter.Optional }
        );

            routes.MapRoute(
            name: "Route2", // my custom route name
            url: "Route2/{Id}",  //url pattern for my custom route
            defaults: new { controller = "HomeForCustomRoute", action = "About" },
            constraints: new { Id = @"\d+" }
        );

            routes.MapRoute(
           name: "Route3", // my custom route name
           url: "ByAction/{action}/{abc}",  //url pattern for my custom route
           defaults: new { action = "Index",controller="Home",abc=UrlParameter.Optional}
           
       );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


            //MVC framework evaluates each route in sequence. 
            //    It starts with first configured route and 
            //if incoming url doesn't satisfy the URL pattern of the route then
            //it will evaluate second route and so on. In the above example,
            //    routing engine will evaluate Student route first and 
            //if incoming url doesn't starts with /students then
            //only it will consider second route which is default route.

            //Route must be registered in Application_Start event in Global.ascx.cs file.
            
        }
    }
}