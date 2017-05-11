using System.Web.Mvc;
using System.Web.Routing;

namespace Infnet.WebApi.Tp1.Presentation
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Contact", action = "ContactWithEmail" }
            );

            routes.MapRoute(
                name: "ContactWithEmail",
                url: "Contact/ContactWithEmail",
                defaults: new { controller = "Contact", action = "ContactWithEmail" }
            );

            routes.MapRoute(
                name: "ContactWithPhone",
                url: "Contact/ContactWithPhone",
                defaults: new { controller = "Contact", action = "ContactWithPhone" }
            );
        }
    }
}
