using System.Web;
using System.Web.Mvc;

namespace lab_123_northwind_from_scratch
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
