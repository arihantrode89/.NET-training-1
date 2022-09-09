using DependencyInjectionDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Repository
{
    internal interface Interface1
    {
        List<Employee> GetAll();
    }
}
