using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCore.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        [Required(ErrorMessage ="Dept Name is Required")]
        public string DeptName { get; set; }

        [ForeignKey("DepartmentId")]
        public ICollection<Employee> Employees { get; set; }
    }
}
