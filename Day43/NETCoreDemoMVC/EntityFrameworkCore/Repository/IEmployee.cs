using EntityFrameworkCore.Models;
using System.Collections.Generic;

namespace EntityFrameworkCore.Repository
{
    public interface IEmployee
    {
        List<Employee> GetEmployees();
    }
}
