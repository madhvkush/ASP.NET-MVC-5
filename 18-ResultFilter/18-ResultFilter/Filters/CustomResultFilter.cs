using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _18_ResultFilter.Filters
{
    public class CustomResultFilter :FilterAttribute,IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("After Result(Action-method) Executed");
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("Before Result(Action-method) Executed");
        }
    }

    public class CustomActionResultFilter : ActionFilterAttribute
    {
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("After Result Executed");
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("Before Result Executed");
        }

        public override void OnActionExecuting (ActionExecutingContext filterContext )
        {
            filterContext.HttpContext.Response.Write("Before Action Executed");
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("After Action Executed");
        }
    }
}