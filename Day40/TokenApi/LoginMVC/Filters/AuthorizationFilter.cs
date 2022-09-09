using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginMVC.Filters
{
    public class AuthorizationFilter : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                var a= filterContext.HttpContext.Request.Cookies["UserData"]["Name"];
                if (filterContext.HttpContext.Session["token"].ToString() != null && filterContext.HttpContext.Session["role"].ToString() == "Admin")
                {
                    //filterContext.Result = new ViewResult();
                    //filterContext.Result.ExecuteResult(filterContext.Controller.ControllerContext);
                }
                else
                {
                    filterContext.Result = new RedirectResult("~Login/Login",true);
                }
            }
            catch
            {
                filterContext.Result = new RedirectResult("~/Login/Login",true); ;
            }
        }
    }
}