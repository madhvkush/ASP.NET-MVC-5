using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHelpers.CustomHelpers
{
    
        public static class CustomHelper
        {
            public static MvcHtmlString Image(string source, string altTxt, string width, string height, string ValidationType)
            {
                //TagBuilder creates a new tag with the tag name specified    
                var ImageTag = new TagBuilder("img");
                //MergeAttribute Adds attribute to the tag    
                ImageTag.MergeAttribute("src", source);
                ImageTag.MergeAttribute("alt", altTxt);
                ImageTag.MergeAttribute("width", width);
                ImageTag.MergeAttribute("height", height);
                ImageTag.MergeAttribute("data-Validation-type", ValidationType);
                //Return an HTML encoded string with SelfClosing TagRenderMode    
                return MvcHtmlString.Create(ImageTag.ToString(TagRenderMode.SelfClosing));
            }
        }    
    
}