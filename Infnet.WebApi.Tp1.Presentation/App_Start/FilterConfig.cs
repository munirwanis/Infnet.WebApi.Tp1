using System.Web;
using System.Web.Mvc;

namespace Infnet.WebApi.Tp1.Presentation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
