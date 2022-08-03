using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_Collection
{
    internal class StudentManagement
    {
        static void Main(string[] args)
        {
            Boolean flg = true;
            StudentIO obj = new StudentIO();
            do
            {
                byte ch = obj.Menu();
                switch (ch)
                {
                    case 1:
                        obj.Add();
                        Console.WriteLine("".PadLeft(30, '-'));
                        flg = true;
                        break;
                    case 2:
                        obj.Update();
                        Console.WriteLine("".PadLeft(30, '-'));

                        flg = true;
                        break;
                    case 3:
                        obj.AllDetails();
                        Console.WriteLine("".PadLeft(30, '-'));

                        flg = true;
                        break;
                    case 4:
                        obj.SpecificDetail();
                        Console.WriteLine("".PadLeft(30, '-'));

                        flg = true;
                        break;
                    case 5:
                        obj.Delete();
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
