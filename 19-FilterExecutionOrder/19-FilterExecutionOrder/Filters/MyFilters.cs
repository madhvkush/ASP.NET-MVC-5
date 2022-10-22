using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _19_FilterExecutionOrder.Filters
{
    public class CustomActionFilters : FilterAttribute,IActionFilter
    {

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("After Action Executed  <br/>");
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("Before Action Executed  <br/>");
        }
    }

    public class CustomExceptionFilters : FilterAttribute, IExceptionFilter
    {

        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            filterContext.HttpContext.Response.Write("Exception Filter <br/>");
            //filterContext.Result = new RedirectResult("/Home/OnExceptionFire");
        }
    }
    public class CustomResultFilters : FilterAttribute, IResultFilter
    {

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {

            filterContext.HttpContext.Response.Write("After Result Executed  <br/>");
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {

            filterContext.HttpContext.Response.Write("Before Result Executed  <br/>");
        }
    }

    public class CustomAuthorizeFilter:FilterAttribute,IAuthorizationFilter
    {

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            filterContext.HttpContext.Response.Write("Authorized filter   <br/>");
        }
    }
}