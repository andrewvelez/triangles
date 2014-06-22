using System.Web;
using System.Web.Http;

namespace DefaultWebApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(HttpConfiguration config)
        {
            //filters.Add(new HandleErrorAttribute());
            config.Filters.Clear();
            config.Filters.
        }
    }
}
