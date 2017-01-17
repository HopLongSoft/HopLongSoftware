using System.Web.Mvc;

namespace SYSTEM_MANAGEMENT.Areas.TruongAnHN
{
    public class TruongAnHNAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TruongAnHN";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "TruongAnHN_default",
                "TruongAnHN/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}