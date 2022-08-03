using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            StudentMethod obj = new StudentMethod();
            Boolean flg = true;
            int ch;
            Student[] arr = new Student[0];
            do
            {
                Console.WriteLine("Choose following option:\n" +
                    "1.Add Student Details\n2.Show All details\n3.Update Details\n4.Delete details\n" +
                    "5.Exit\n");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        arr = obj.AddStudent(arr);
                        Console.WriteLine("".PadLeft(30, '-'));
                        flg = true;
                        break;

                    case 2:
                        obj.ShowDetails(arr);
                        Console.WriteLine("".PadLeft(30, '-'));
                        flg = true;
                        break;

                    case 3:
                        obj.UpdateDetails(arr);
                        Console.WriteLine("".PadLeft(30, '-'));
                        flg = true;
                        break;

                    case 4:
                        arr = obj.DeleteDetails(arr);
                        flg = true;
                        Console.WriteLine("".PadLeft(30, '-'));
                        break;

                    case 5:

                        flg = false;
                        break;
                }
            } while (flg);
        }
    }
}
