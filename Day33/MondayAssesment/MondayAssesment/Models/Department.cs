using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MondayAssesment.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }

        [Required(ErrorMessage = "Department Name is Required")]
        public string DeptName { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}