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
    public class EmployeeController : Controller
    {
        // GET: Employee
        [HttpGet]
        public ActionResult Index()
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
            return View(data);
        }

        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee emp)
        {
            if (ModelState.IsValid)
            {
                string url = "https://localhost:44333/AddEmployee";
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Accept:application/json");
                    webClient.Headers.Add("Content-type:application/json");
                    var json = JsonConvert.SerializeObject(emp);
                    webClient.UploadString(url, json);
                }
                return RedirectToAction("Index");
            }
            return View();

        }

        public ActionResult EditEmployee(int id)
        {
            string url = $"https://localhost:44333/getempdetails/{id}";
            dynamic data;
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Accept:application/json");
                webClient.Headers.Add("Content-type:application/json");
                var respone = webClient.DownloadString(url);
                data = JsonConvert.DeserializeObject<Employee>(respone);
            }
            return View(data);
        }

        [HttpPost]
        public ActionResult EditEmployee(Employee emp)
        {
            string url = "https://localhost:44333/EditEmployee";
            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Accept:application/json");
                webClient.Headers.Add("Content-type:application/json");
                var json = JsonConvert.SerializeObject(emp);
                webClient.UploadString(url,"PUT", json);
            }
            return RedirectToAction("Index");
        }


        public ActionResult DeleteEmployee(int id)
        {
            string url = $"https://localhost:44333/api/Employee/DelEmployee/{id}";

            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Accept:application/json");
                webClient.Headers.Add("Content-type:application/json");
                string res = webClient.UploadString(url, "Delete", "");
                
            }
            return RedirectToAction("Index");
        }
    }
}