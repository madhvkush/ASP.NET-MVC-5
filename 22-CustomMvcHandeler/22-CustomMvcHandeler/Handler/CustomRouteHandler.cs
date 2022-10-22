using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace _22_CustomMvcHandeler.Handler
{
    public class CustomRouteHandler : IRouteHandler
    {
        //it will return a http-handler
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new CustomHttpHandler();

        }
    }

    public class CustomHttpHandler:IHttpHandler
    {

        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            var req = context.Request;
            var VirtualURL=context.Request.FilePath;
            var Resources = VirtualURL.Split('/');
            // Resources=Resources.
            //context.Response.Redirect("~/Home/Index");// you can redirect this response.
            context.Response.Write("This request is handover to a custom http-handler.");
            
        }
    }

}