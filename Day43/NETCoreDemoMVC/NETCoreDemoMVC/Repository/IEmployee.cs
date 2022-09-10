using NETCoreDemoMVC.Models;
using System.Collections.Generic;

namespace NETCoreDemoMVC.Repository
{
    public interface IEmployee
    {
        List<EmployeeModel> GetEmployees();
    }
}
