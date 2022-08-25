using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MVC_Entity_Practice.Models
{
    public class Employee
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Departments { get; set; } 
    }
}