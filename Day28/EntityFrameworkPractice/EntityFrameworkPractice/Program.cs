using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataAccessClass obj = new DataAccessClass();
            var courses = new Course()
            {
                CourseName="Machine Learning",
                Students = new List<Student>()
                {
                    new Student(){Name="Arihant",Email="arihantrode89@gmail.com"},
                    new Student(){Name="Ayushya",Email="ayushya@gmail.com"},
                    new Student(){Name="Aditya",Email="aditya9@gmail.com"},
                }
            };

            //obj.AddCourses(courses);

            var data = obj.GetCourses().FirstOrDefault();

            if (data != null)
            {
                Console.WriteLine($"Course Name: {data.CourseName}");
                foreach(var item in data.Students)
                {
                    Console.WriteLine($"Name: {item.Name}\tEmail: {item.Email}");
                    Console.WriteLine("".PadLeft(30,'-'));
                }
            }

            
        }
    }
}
