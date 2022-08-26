using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomFilterDemo.Controllers.Filters
{
    public class CustomResultAttribute : FilterAttribute, IResultFilter
    {

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.OnResultExecuting = " IResultFilter.OnResultExecuting called";

        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.Controller.TempData["OnResultExecuted"] = " IResultFilter.OnResultExecuted called";

        }
    }
}