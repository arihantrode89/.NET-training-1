using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPractice
{
    internal class DataAccessClass
    {
        DataBaseContext obj = new DataBaseContext();
        public List<Student> GetStudent()
        {
            return obj.Students.ToList();
        }

        public List<Course> GetCourses()
        {
            return obj.Courses.ToList();
        }

        public void AddStudent(Student std)
        {
            obj.Students.Add(std);
            obj.SaveChanges();
        }

        public void AddCourses(Course c)
        {
            obj.Courses.Add(c);
            obj.SaveChanges();
        }


    }
}
