using System.Web;
using System.Web.Mvc;

namespace webapp1_aadb2c
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
