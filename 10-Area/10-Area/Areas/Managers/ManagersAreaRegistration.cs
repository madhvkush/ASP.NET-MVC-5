using System.Web.Mvc;

namespace _10_Area.Areas.Managers
{
    public class ManagersAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Managers";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Managers_default",
                "Managers/{controller}/{action}/{id}",
                new { controller="Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
