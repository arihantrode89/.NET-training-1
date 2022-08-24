using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Entity_Practice.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}