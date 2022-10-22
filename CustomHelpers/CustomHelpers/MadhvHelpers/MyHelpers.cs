using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace MadhvHelpers
{
    public static class MyHelpers
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
            string str = ImageTag.ToString(TagRenderMode.SelfClosing) + "<input type='button' value='ok' id='btnImg' onclick='funClick()' />" +
                "<script type='text/javascript'>function funClick(){ alert('Hello Button is Clicked');}</script>";
            return MvcHtmlString.Create(str);
        }

        /// <summary>
        /// <para>Texbox for Add-Items</para>
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression">Write Lambda Expression</param>
        /// <param name="PlaceHolder">Place Holder</param>
        /// <param name="ValidationType">Validation Type</param>
        /// <param name="DataType">Data Type</param>
        /// <param name="IsMendatory">Is this field Mendatory?</param>
        /// <param name="CatId">Category-Id</param>
        /// <returns></returns>
        public static MvcHtmlString TextBoxFor_AddItem<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string PlaceHolder, string ValidationType, string DataType, bool IsMendatory, int CatId)
        {
            var name = ExpressionHelper.GetExpressionText(expression);
            var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("type", "text");
            tb.Attributes.Add("name", name);
            tb.Attributes.Add("placeholder", PlaceHolder);
            tb.Attributes.Add("data-ValidationType", ValidationType);
            tb.Attributes.Add("data-DataType", DataType);
            tb.Attributes.Add("IsMendatory", IsMendatory.ToString());
            tb.Attributes.Add("CategoryId", CatId.ToString());
            tb.Attributes.Add("value", metadata.Model as string);
            return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));
        }

        /// <summary>
        /// <para>Check box for Add Item</para>
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression">Write Lambda Expression</param>
        /// <param name="ValidationType">Validation Type</param>
        /// <param name="DataType">Data Type</param>
        /// <param name="IsMendatory">Is this field Mendatory?</param>
        /// <param name="CatId">Category-Id</param>
        /// <returns></returns>

        public static MvcHtmlString CheckBoxFor_AddItem<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string ValidationType, string DataType, bool IsMendatory, int CatId)
        {
            var name = ExpressionHelper.GetExpressionText(expression);
            var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("type", "checkbox");
            tb.Attributes.Add("name", name);
            tb.Attributes.Add("data-ValidationType", ValidationType);
            tb.Attributes.Add("data-DataType", DataType);
            tb.Attributes.Add("IsMendatory", IsMendatory.ToString());
            tb.Attributes.Add("CategoryId", CatId.ToString());
            tb.Attributes.Add("value", metadata.Model as string);
            return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));
        }

        public static MvcHtmlString RadioFor_AddItem<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string ValidationType, string DataType, bool IsMendatory, int CatId)
        {
            var name = ExpressionHelper.GetExpressionText(expression);
            var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("type", "radio");
            tb.Attributes.Add("name", name);
            tb.Attributes.Add("data-ValidationType", ValidationType);
            tb.Attributes.Add("data-DataType", DataType);
            tb.Attributes.Add("IsMendatory", IsMendatory.ToString());
            tb.Attributes.Add("CategoryId", CatId.ToString());
            tb.Attributes.Add("value", metadata.Model as string);
            return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));
        }
    }
}
