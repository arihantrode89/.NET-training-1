using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataAccessHelper dataAccessHelper = new DataAccessHelper();

            Department dept = new Department()
            {
                //DepartmentId = 100,
                DepartmentName = "IT Department",
                //DepartmentDescription = "This is HR Department",
                Employees = new List<Employee>()
                {
                    new Employee()
                    { 
                        EmployeeName = "Arihant"
                    },
                    new Employee()
                    {
                        EmployeeName = "Ayushya"
                    },
                    new Employee()
                    {
                        EmployeeName = "Amit"
                    }
                }
            };

            dataAccessHelper.AddDepartment(dept);

            var deptdata = dataAccessHelper.FetchDepartment().First();
            if (deptdata != null)
            {
                Console.WriteLine(deptdata.DepartmentName);
                Console.WriteLine("List of Employees are :");
                foreach(var item in deptdata.Employees)
                {
                    Console.WriteLine(item.EmployeeName);
                }
            }
        }
    }
}
