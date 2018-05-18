using System.Web;
using System.Web.Mvc;

namespace aspnet_webapp_to_ci_cd.webapp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
