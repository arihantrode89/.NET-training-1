using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_Collection
{
    internal class StudentService:IStudent
    {
        List<Student> obj = new List<Student>();
        public void AddStudent(int id, string name, string address, float Totalmarks, float ObtainedMarks)
        {
            Student std = new Student(id,name,address,Totalmarks, ObtainedMarks);
            obj.Add(std);
        }
        public Student SpecificStudent(int id)
        {
            if(obj.Count != 0)
            {
                for(int i = 0; i < obj.Count; i++)
                {
                    if (obj[i].Id == id)
                    {
                        return obj[i];
                    }
                }
                return null;
            }
            else
            {
                return null;
            }
        }

        public void ShowDetails()
        {
            foreach(Student std in obj)
            {
                Console.WriteLine($"Id:{std.Id}\nName:{std.Name}\nAddress:{std.Address}\n" +
                $"Obtained Marks:{std.ObtainedMarks}\nTotal Marks:{std.TotalMarks}");

                Console.WriteLine("".PadLeft(30, '-'));
            }
        }
        public Boolean UpdateDetails(int id)
        {
            Student std = SpecificStudent(id);
            if (std != null)
            {
                //DisplaySpecificDetail(id);
                Console.WriteLine("Choose what you want to update\n" +
                        "1.Name\n2.Address\n3.Obtained Marks\n4.Total Marks\n5.Exit\n");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {

                    case 1:
                        Console.WriteLine("Enter Name:");
                        std.Name = Console.ReadLine();
                        return true;

                    case 2:
                        Console.WriteLine("Enter Address:");
                        std.Address = Console.ReadLine();
                        return true;

                    case 3:
                        Console.WriteLine("Enter Obtained Marks:");
                        std.ObtainedMarks = float.Parse(Console.ReadLine());
                        return true;

                    case 4:
                        Console.WriteLine("Enter Total Marks:");
                        std.TotalMarks = float.Parse(Console.ReadLine());
                        return true;

                    default:
                        return false;


                }
            }
            else
            {
                Console.WriteLine("No such student exist");
                return false;
            }
        }

        public Boolean DeleteDetails(int id)
        {
            if (obj.Count > 0)
            {
                Student std = SpecificStudent(id);
                if (std != null)
                {
                    obj.Remove(std);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void DisplaySpecificDetail(int id)
        {
            Student std = SpecificStudent(id);
            if (std != null)
            {
                Console.WriteLine($"Id:{std.Id}\nName:{std.Name}\nAddress:{std.Address}\n" +
                    $"Obtained Marks:{std.ObtainedMarks}\nTotal Marks:{std.TotalMarks}");
            }
            else
            {
                Console.WriteLine("No such student exist");
            }
          
        }

    }
}
