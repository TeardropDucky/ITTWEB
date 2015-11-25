using System.Web;
using System.Web.Mvc;

namespace HandIn2_FoodProcessor
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
