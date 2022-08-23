using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_ModelDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
    }
}