using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelgatesAndEventAssesment
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Event obj = new Event();
            obj.alert += new Event.Altdelegate(AlertMessage);
            obj.Attendance();
            
        }

        public static void AlertMessage(string name)
        {
            Console.WriteLine($"{name} is not allowed to login into organization applicaiton\n");
        }
    }
}
