using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionTask
{
    internal class BankException:ApplicationException
    {
        public void MinBalance()
        {
            Console.WriteLine("Minimum balance should be 500");
        }
    }
}
