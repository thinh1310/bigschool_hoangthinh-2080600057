using System.Web;
using System.Web.Mvc;

namespace hoangthinh_2080600057
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
