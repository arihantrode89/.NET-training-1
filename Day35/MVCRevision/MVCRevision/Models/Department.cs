using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRevision.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Department> dept = new List<Department>()
        {
            new Department(){ Id = 1, Name = "IT" },
            new Department(){ Id = 2, Name = "HR" },
            new Department(){ Id = 3, Name = "KP" },
            new Department(){ Id = 4, Name = "AB" },
        };

        public static List<Department> GetDepartments()
        {
            return dept;
        }
    }
}