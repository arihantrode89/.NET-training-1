using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredDemo
{
    internal class EmployeeDepartmentPresentationLayer
    {
        static void Main(string[] args)
        {
            EmployeeDepartmentIO empDeptIO = new EmployeeDepartmentIO();
            Boolean flg = true;
            do
            {
                byte ch = empDeptIO.Menu();
                switch (ch)
                {
                    case 1:
                        empDeptIO.AddStudent();
                        Console.WriteLine("".PadLeft(30, '-'));
                        flg = true;
                        break;
                    case 2:
                        empDeptIO.Update();
                        Console.WriteLine("".PadLeft(30, '-'));

                        flg = true;
                        break;
                    case 3:
                        empDeptIO.ShowData();
                        Console.WriteLine("".PadLeft(30, '-'));

                        flg = true;
                        break;
                    case 4:
                        empDeptIO.ShowSpecificData();
                        Console.WriteLine("".PadLeft(30, '-'));

                        flg = true;
                        break;
                    case 5:
                        empDeptIO.DeleteData();
                        Console.WriteLine("".PadLeft(30, '-'));

                        flg = true;
                        break;
                    case 6:
                        flg = false;
                        break;
                    default:
                        Console.WriteLine("Wrong Choice..Please Enter Again");
                        flg = true;
                        break;

                }

            } while (flg);
        }
    }
}
