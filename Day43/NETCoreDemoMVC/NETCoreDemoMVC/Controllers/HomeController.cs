using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NETCoreDemoMVC.Models;
using NETCoreDemoMVC.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NETCoreDemoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployee _employees;
        public HomeController(ILogger<HomeController> logger,IEmployee emp)
        {
            _logger = logger;
            _employees = emp;
        }

        public List<EmployeeModel> Index()
        {
            return _employees.GetEmployees();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
