using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MondayAssesment.Filters
{
    public class DepartmentException : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            filterContext.Result = new RedirectResult("~/Employee/AddDepartment");
            filterContext.Controller.TempData["ErrorMessage"] = filterContext.Exception.Message;
        }
    }
}