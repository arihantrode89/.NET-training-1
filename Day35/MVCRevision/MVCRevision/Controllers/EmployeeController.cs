using MVCRevision.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRevision.Controllers
{
    public class EmployeeController : Controller
    {

        public ActionResult Sample()
        {
            //Linq group by 
            //var data = Employee.GetEmployees().GroupBy(x => x.City);
            //foreach(var item in data)
            //{
            //    Response.Write($"<b>{item.Key}</b><br/>");
            //    foreach(var emp in item)
            //    {
            //        Response.Write(emp.Name+" ");
            //    }
            //    Response.Write("<br/>");
            //}

            var emp = Employee.GetEmployees();
            var dept = Department.GetDepartments();
            //2ways of inner join
            var joindata = emp.Join(dept, s => s.DepartmentId, d => d.Id, (s, d) => new {empName=s.Name,dname=d.Name});
            var joindata1 = from e in emp join d in dept on e.DepartmentId equals d.Id select new {empName=e.Name,dname=d.Name};
            foreach(var item in joindata1)
            {
                Response.Write($"Employee Name: {item.empName} &nbsp Department: {item.dname} <br/>");
                
            }
            Response.Write("<br/><br/>");
            var groupdept = joindata.GroupBy(s => s.dname);
            foreach (var item in groupdept)
            {
                Response.Write($"<b>{item.Key}</b><br/>");
                foreach (var e in item)
                {
                    Response.Write($"{e.empName} <br/>");

                }
            }
            Response.Write("<br/><br/>");

            var groupdept1 = from d in dept join e in emp on d.Id equals e.DepartmentId into empgroup select new { employee=empgroup,dname=d.Name};
            foreach (var item in groupdept1)
            {
                Response.Write($"<b>{item.dname}</b><br/>");
                foreach (var e in item.employee)
                {
                    Response.Write($"{e.Name} <br/>");

                }
            }

            return View();
        }
        // GET: Employee
        public ActionResult Index()
        {

            var data = Employee.GetEmployees();

            return View(data);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var data = Employee.GetEmployees().FirstOrDefault(s => s.Id == id);
            return View(data);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                Employee.Add(emp);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Employee.GetEmployees().FirstOrDefault(s => s.Id == id);

            return View(data);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,Employee emp)
        {
            try
            {
                // TODO: Add update logic here
                Employee.Edit(emp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            var data = Employee.GetEmployees().FirstOrDefault(s => s.Id == id);
            return View(data);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Employee.Remove(id);
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
