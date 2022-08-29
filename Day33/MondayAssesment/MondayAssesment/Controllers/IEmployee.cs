using MondayAssesment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MondayAssesment.Controllers
{
    internal interface IEmployee
    {
        ActionResult GetEmployees();
        ActionResult AddEmployee();
        ActionResult AddEmployee(Employee emp);
        ActionResult UpdateEmployee(int id);
        ActionResult UpdateEmployee(Employee emp);
        ActionResult DeleteEmployee(int id);
    }
}
