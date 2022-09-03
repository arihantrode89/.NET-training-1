using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApiConsume.Models;

namespace ConsumeApiMvc1.Controllers
{
    public class AjaxDemoController : Controller
    {
        // GET: AjaxDemo
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public string abc()
        {
            return "Abc";
        }
        [HttpGet]
        public JsonResult jjson()
        {
            dynamic data;
            string url = "https://localhost:44333/GetEmployee";
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Accept:application/json");
                webClient.Headers.Add("Content-type:application/json");
                var response = webClient.DownloadString(url);
                data = JsonConvert.DeserializeObject<List<Employee>>(response);

            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}