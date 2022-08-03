using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> obj = new List<Student>();
            Console.WriteLine("How many student details you want to store?");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Student student = new Student();
                student.GetData1(i);
                obj.Add(student);
                Console.WriteLine("".PadLeft(30, '-'));

            }
            Console.Write("Enter Id for updation:");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                if (obj[i].Id == id)
                {
                    Console.WriteLine("This are the details you want to update:\n");
                    obj[i].Display();
                    obj[i].UpdateData();
                    break;
                }
                
            }
            Console.WriteLine("Following are the student details:");
            for (int i = 0; i < num; i++)
            {
                obj[i].Display();
                Console.WriteLine("".PadLeft(30, '-'));
            }


            Student s1 = new Student();
            s1.GetData2();
            s1.Display1();

        }
    }
}
