using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_CustomActionFilter.Filter
{
   
   
    public class MyCustomCode :FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.RouteData.Values.Add("before", "executed before action method");

        }
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.RouteData.Values.Add("after", "executed after action method");
        }


    }
}