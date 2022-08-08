using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_LinqDemo
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Char Gender { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ Id=1, Name="Arihant",Age=22,Gender='M'},
                new Student(){ Id=2, Name="Ayushya",Age=22,Gender='F'},
                new Student(){ Id=3, Name="Chirag",Age=22,Gender='M'},
                new Student(){ Id=4, Name="Aastha",Age=22,Gender='F'},
            };

            IEnumerable<Student> std = from item in students
                                       where item.Gender == 'F'
                                       select item;

            foreach(var student in std)
            {
                Console.WriteLine(student.Name+' '+student.Gender);
            }


        }
    }
}
