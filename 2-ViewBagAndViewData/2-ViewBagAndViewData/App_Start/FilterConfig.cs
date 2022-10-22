using System.Web;
using System.Web.Mvc;

namespace _2_ViewBagAndViewData
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}