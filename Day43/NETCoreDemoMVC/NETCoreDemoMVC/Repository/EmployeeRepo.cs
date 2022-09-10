using NETCoreDemoMVC.Models;
using System.Collections.Generic;

namespace NETCoreDemoMVC.Repository
{
    public class EmployeeRepo : IEmployee
    {
        private List<EmployeeModel> emp = new List<EmployeeModel>();
        public List<EmployeeModel> GetEmployees()
        {
            emp.Add(new EmployeeModel() { Id = 1, EmpName = "Arihant", Role = "SDE" });
            emp.Add(new EmployeeModel() { Id = 2, EmpName = "Ayuhsya", Role = "SDE" });
            emp.Add(new EmployeeModel() { Id = 3, EmpName = "AKshya", Role = "SDE" });
            return emp;
        }
    }
}
