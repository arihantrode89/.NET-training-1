using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        public MondayAssesmentEntities db = new MondayAssesmentEntities();

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
            db.UpdateEmployee(data.EmployeeId, data.Name, data.Gender, data.City, data.Salary, data.DepartmentId);
            db.SaveChanges();
        }

        [HttpGet]
        [Route("getempdetails/{id}")]
        public Employee GetEmpDetails(int id)
        {
            var data = db.Employees.FirstOrDefault(s => s.EmployeeId == id);
            return data;
        }

        [HttpGet]
        [Route("getempdetailsname")]
        public Employee GetEmpDetailsByUsername(string Name)
        {
            //var query = Request.GetQueryNameValuePairs();
            //var user = query.FirstOrDefault(s => s.Key == "Name").Value;
            var data = db.Employees.FirstOrDefault(s => s.Name == Name);
            return data;
        }

        [HttpDelete]
        [Route("DelEmployee/{id}")]
        public void DelEmployee(int id)
        {
            db.DeleteEmployee(id);
            //var data = db.Employees.FirstOrDefault(s => s.EmployeeId == id);
            //db.Employees.Remove(data);
            db.SaveChanges();
        }

        [HttpGet]
        [Route("GetDepartment")]
        public List<Department> GetDepartment()
        {
            List<Department> data = db.Departments.ToList();
            return data;
        }
    }
}
