using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MondayAssesment.Filters
{
    public class ParticularEmployeeException : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            int id = Convert.ToInt32(filterContext.RouteData.Values["id"].ToString());
            filterContext.Result = new RedirectResult($"~/Employee/AddEmployee/{id}");
            filterContext.Controller.TempData["ErrorMessage"] = filterContext.Exception.Message;
        }
    }
}