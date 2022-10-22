using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;

namespace MadhvHelpers
{
    /// <summary>
    /// <para>Create Option to add with dropdown</para>
    /// </summary>
    public sealed class Options
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public bool IsChecked;
    }
   public static class DropDownWithcheckBox
    {
       /// <summary>
       /// <para>Dropdown with checkboxes for model binding</para>
       /// </summary>
       /// <typeparam name="TModel"></typeparam>
       /// <typeparam name="TProperty"></typeparam>
       /// <param name="htmlHelper"></param>
       /// <param name="expression"></param>
       /// <param name="ControlID">Unique-Id of Element</param>
       /// <param name="OptionsList">List of Options to attach</param>
       /// <returns></returns>
       public static MvcHtmlString MS_DropDownWithcheckBox<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
           Expression<Func<TModel, TProperty>> expression, string ControlID, List<Options> OptionsList)
       {
           var name = ExpressionHelper.GetExpressionText(expression); //name of control which return value on post (hidden-control)
          // var metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
           
           var SelecteText=string.Join(",",OptionsList.Where(op=>op.IsChecked).Select(op=>op.Text).ToList());
           var SelectedValue=string.Join(",", OptionsList.Where(op => op.IsChecked).Select(op => op.Value).ToList());

           StringBuilder sb = new StringBuilder();
           sb.Append("<div class='ui-dropdownchecklist-wrapper' style='display: inline-block; cursor: default;'>");
           sb.Append("<div class='ui-dropdownchecklist' style='display: inline-block;'>");
           sb.Append("<input id='"+ControlID+ "' type='text' value='"+SelecteText+"' class='ui-dropdownchecklist-text' style='display: inline-block;  width: 150px; height:inherit' readonly='readonly' />");
           sb.Append("<input type='hidden'  value='"+ SelectedValue + "' name='"+ name +"'  >");
           sb.Append("</div></div>");
           
           sb.Append("<div  class='ui-dropdownchecklist-dropcontainer' name='"+ControlID+"' style='overflow-y: auto; height: 68px; display:none'>");
           foreach(var optn in OptionsList)
           {
               sb.Append("<div class='ui-dropdownchecklist-item' style='white-space: nowrap;' onclick='onClickCheckBoxLine(this)'>");
               if(optn.IsChecked)
                   sb.Append("<input type='checkbox' disabled Checked='Checked' value='" + optn.Value + "'>");
               else sb.Append("<input type='checkbox' disabled value='" + optn.Value + "'>");
               sb.Append("<span class='ui-dropdownchecklist-text' style='cursor: default; width: 100%;'>"+optn.Text+"</span>");
               sb.Append("</div>");
           }
           
           sb.Append("</div>");

           return new  MvcHtmlString(sb.ToString());
       }

       /// <summary>
       /// <para>DropDown with checkboxes</para>
       /// </summary>
       /// <param name="htmlHelper"></param>
       /// <param name="ControlName">Name of control(by using this name u will get value on post)</param>
       /// <param name="ControlID">Unique-Id of Element</param>
       /// <param name="OptionsList">List of Options to attach</param>
       /// <returns></returns>
       public static MvcHtmlString MS_DropDownWithcheckBox(this HtmlHelper htmlHelper,string ControlName, string ControlID, List<Options> OptionsList)
       {
           var name = ControlName; //name of control which return value on post (hidden-control)

           var SelecteText = string.Join(",", OptionsList.Where(op => op.IsChecked).Select(op => op.Text).ToList());
           var SelectedValue = string.Join(",", OptionsList.Where(op => op.IsChecked).Select(op => op.Value).ToList());

           StringBuilder sb = new StringBuilder();
           sb.Append("<div class='ui-dropdownchecklist-wrapper' style='display: inline-block; cursor: default;'>");
           sb.Append("<div class='ui-dropdownchecklist' style='display: inline-block;'>");
           sb.Append("<input id='" + ControlID + "' type='text' value='" + SelecteText + "' class='ui-dropdownchecklist-text' style='display: inline-block;  width: 150px; height:inherit' readonly='readonly' />");
           sb.Append("<input type='hidden'  value='" + SelectedValue + "' name='" + name + "'  >");
           sb.Append("</div></div>");

           sb.Append("<div  class='ui-dropdownchecklist-dropcontainer' name='" + ControlID + "' style='overflow-y: auto; height: 68px; display:none'>");
           foreach (var optn in OptionsList)
           {
               sb.Append("<div class='ui-dropdownchecklist-item' style='white-space: nowrap;' onclick='onClickCheckBoxLine(this)'>");
               if (optn.IsChecked)
                   sb.Append("<input type='checkbox' disabled Checked='Checked' value='" + optn.Value + "'>");
               else sb.Append("<input type='checkbox' disabled value='" + optn.Value + "'>");
               sb.Append("<span class='ui-dropdownchecklist-text' style='cursor: default; width: 100%;'>" + optn.Text + "</span>");
               sb.Append("</div>");
           }

           sb.Append("</div>");

           return new MvcHtmlString(sb.ToString());
       }
    }
}
