using System.Web;
using System.Web.Mvc;

namespace TranMinhTan_Big_School
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
