using System.Web;
using System.Web.Mvc;

namespace Hand_in1_grp7
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
