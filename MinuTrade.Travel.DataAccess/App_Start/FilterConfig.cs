using System.Web;
using System.Web.Mvc;

namespace MinuTrade.Travel.DataAccess
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}