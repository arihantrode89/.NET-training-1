using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Partial1
    {
        public void Display()
        {
            Console.WriteLine("Employee Name: {0}\nEmpId:{1}\nRole:{2}\nGender:{3}", Name, Id, Role,Gender);
        }
    }
}
