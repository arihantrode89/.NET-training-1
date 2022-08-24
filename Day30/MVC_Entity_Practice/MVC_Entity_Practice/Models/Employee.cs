using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Entity_Practice.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Departments { get; set; } 
    }
}