using System.Web;
using System.Web.Mvc;
using CustomFilterDemo.Controllers.Filters;
namespace CustomFilterDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomActionAttribute());
            filters.Add(new CustomAuthorizationAttribute());
            filters.Add(new CustomExceptionAttribute());
            filters.Add(new CustomResultAttribute());
        }
    }
}
