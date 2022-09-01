using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRevision.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }

        public int DepartmentId { get; set; }

        public static List<Employee> emp = new List<Employee>()
            {
                new Employee(){ Id=1,Name="Arihant",City="Nagpur",PostalCode=440008,DepartmentId=1},
                new Employee(){ Id=2,Name="Ayushya",City="Lucknow",PostalCode=445008,DepartmentId=2},
                new Employee(){ Id=3,Name="Amit",City="Agra",PostalCode=440508,DepartmentId=3},
                new Employee(){ Id=4,Name="Aditya",City="Nagpur",PostalCode=420008,DepartmentId=2},
                new Employee(){ Id=5,Name="Ashish",City="Lucknow",PostalCode=470008,DepartmentId=3},
            };
        public static List<Employee> GetEmployees()
        {
            return emp;
        }

        public static void Add(Employee e)
        {
            emp.Add(e);
        }

        public static void Remove(int id)
        {
            emp.Remove(emp.First(s=>s.Id==id));
        }

        public static void Edit(Employee e)
        {
            var data = emp.FirstOrDefault(s => s.Id == e.Id);
            data.Name = e.Name;
            data.City = e.City;
            data.PostalCode = e.PostalCode;
        }

    }
}