using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiConsume.Models;

namespace WebApiConsume.Controllers
{
    public class EmployeeController : ApiController
    {
        public MondayAssesmentEntities1 db = new MondayAssesmentEntities1();

        [HttpGet]
        [Route("GetEmployee")]
        public List<Employee> GetEmployees()
        {
            List<Employee> data = db.Employees.ToList();
            return data;
        }

        [HttpPost]
        [Route("AddEmployee")]
        public void AddEmployee([FromBody] JToken emp)
        {
            var data = JsonConvert.DeserializeObject<Employee>(emp.ToString());
            db.Employees.Add(data);
            db.SaveChanges();
        }

        [HttpPut]
        [Route("EditEmployee")]
        public void EditEmployee([FromBody] JToken emp)
        {
            var data = JsonConvert.DeserializeObject<Employee>(emp.ToString());
            var employee = db.Employees.FirstOrDefault(s => s.EmployeeId == data.EmployeeId);
            employee.Name = data.Name;
            employee.Gender = data.Gender;
            employee.City = data.City;
            employee.Salary = data.Salary;
            employee.DepartmentId = data.DepartmentId;
            db.SaveChanges();
        }

        [HttpGet]
        //[Route("GetEmpDetails",Name ="id")]
        public Employee GetEmpDetails(int id)
        {
            var data = db.Employees.FirstOrDefault(s => s.EmployeeId == id);
            return data;
        }

        [HttpDelete]
        public void DelEmployee(int id)
        {
            db.DeleteEmployee(id);
            //var data = db.Employees.FirstOrDefault(s => s.EmployeeId == id);
            //db.Employees.Remove(data);
            db.SaveChanges();
        }
    }
}
