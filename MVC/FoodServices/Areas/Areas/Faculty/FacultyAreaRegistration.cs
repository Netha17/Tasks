using System.Web.Mvc;

namespace Areas.Areas.Faculty
{
    public class FacultyAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Faculty";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Faculty_default",
                "Faculty/{controller}/{action}/{id}",
                new { controller="Home",action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}