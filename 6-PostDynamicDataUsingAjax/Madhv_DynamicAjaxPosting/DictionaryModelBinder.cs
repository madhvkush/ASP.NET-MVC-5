using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Madhv_DynamicAjaxPosting
{
    public class DictionaryModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            if (!controllerContext.HttpContext.Request.ContentType.StartsWith("application/json", StringComparison.OrdinalIgnoreCase))
            {
                return null;
            }

            controllerContext.HttpContext.Request.InputStream.Position = 0;
            using (var reader = new StreamReader(controllerContext.HttpContext.Request.InputStream))
            {
                var json = reader.ReadToEnd();
                if (string.IsNullOrEmpty(json))
                {
                    return null;
                }
                return new JavaScriptSerializer().DeserializeObject(json);
            }
        }
    }
}
