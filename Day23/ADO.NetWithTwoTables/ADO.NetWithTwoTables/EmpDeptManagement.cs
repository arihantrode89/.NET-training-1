using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetWithTwoTables
{
    internal class EmpDeptManagement
    {
        static void Main(string[] args)
        {
            EmpDeptIO empDeptIO = new EmpDeptIO();
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
                        empDeptIO.ShowDetails();
                        Console.WriteLine("".PadLeft(30, '-'));

                        flg = true;
                        break;
                    case 4:
                        empDeptIO.SpecificDetails();
                        Console.WriteLine("".PadLeft(30, '-'));

                        flg = true;
                        break;
                    case 5:
                        empDeptIO.DeleteStudent();
                        Console.WriteLine("".PadLeft(30, '-'));

                        flg = true;
                        break;
                    default:
                        flg = false;
                        break;

                }

            } while (flg);

        }
    }
}
