using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsTask
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "Arihant";
            emp.Email = "abc@gmail.com";
            emp.PriSkill = "C#";
            emp.Id = 7070;

            HrManagement hr = new HrManagement();
            hr.Manage();
            Department dept = new Department();

            

            dept.Location(emp);

            Console.WriteLine("".PadLeft(30, '-'));

            
            dept.AddProj();

            Console.WriteLine("".PadLeft(30, '-'));

            dept.SetWork(emp);

            emp.Working();
            emp.ShowWork();

            Console.WriteLine("".PadLeft(30, '-'));

            emp.Display();

            

            


            
        }
    }
}
