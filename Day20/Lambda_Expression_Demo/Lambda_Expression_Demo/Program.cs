using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> res = list.Where(s=>s%2==0).ToList();

            foreach(var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}
