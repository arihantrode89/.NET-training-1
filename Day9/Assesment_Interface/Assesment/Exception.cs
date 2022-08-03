using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class ArrayException:ApplicationException
    {
        public void EmptyArray()
        {
            Console.WriteLine("There are no details");
        }
    }
}
