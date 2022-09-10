namespace EntityFrameworkCore.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public float Salary { get; set; }
        public virtual int DepartmentId { get; set; }
    }
}
