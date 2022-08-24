using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelStateDemo.Models;

namespace ModelStateDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmployee()
        {
            trainingEntities dbcontext = new trainingEntities();
            var data = dbcontext.tblEmployees.ToList();
            return View(data);
        }

        public ActionResult Details(int id)
        {
            trainingEntities dbcontext = new trainingEntities();
            var data = dbcontext.tblEmployees.Where(m => m.ID == id).FirstOrDefault();
            return View(data);
        }

        
        
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditEmployee(int id,int ID,string Name,string Gender,float Salary,int DepartmentId)
        {
            var data = new trainingEntities();
            var row = data.tblEmployees.Where(s=>s.ID==ID).FirstOrDefault();
            row.Name = Name;
            row.Gender=Gender;
            row.Salary = (int?)Salary;
            row.DepartmentId=DepartmentId;
            data.SaveChanges();
            return View("Details",row);
        }


        public ActionResult Delete(int id)
        {
            TempData["ID"] = id;
            return View();
        }

        public ActionResult DelEmployee()
        {
            var id = TempData["ID"];
            var data = new trainingEntities();
            var row = data.tblEmployees.Where((s)=>s.ID==(int)id).FirstOrDefault();
            var del = data.tblEmployees.Remove(row);
            data.SaveChanges();
            return View("GetEmployee",data.tblEmployees.ToList());
        }
    }
}