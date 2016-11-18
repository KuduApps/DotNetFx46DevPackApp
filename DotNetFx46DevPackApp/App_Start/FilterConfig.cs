using System.Web;
using System.Web.Mvc;

namespace DotNetFx46DevPackApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
