using MondayAssesment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MondayAssesment.Controllers
{
    internal interface IDepartment
    {
        ActionResult GetDepartment();
        ActionResult AddDepartment();
        ActionResult AddDepartment(Department dept);
        ActionResult UpdateDepartment(int id);
        ActionResult UpdateDepartment(Department dept);
        ActionResult DeleteDepartment(int id);
    }
}
