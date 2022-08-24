using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModelDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public float Salary { get; set; }
        public int AddressId { get; set; }
    }
}