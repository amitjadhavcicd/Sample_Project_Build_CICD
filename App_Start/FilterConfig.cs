using System.Web;
using System.Web.Mvc;

namespace Sample_Project_Build_CICD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
