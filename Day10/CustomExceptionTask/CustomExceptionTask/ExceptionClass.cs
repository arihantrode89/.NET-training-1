using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionTask
{
    internal class ExceptionClass:ApplicationException
    {
        public void WrongChoice()
        {
            Console.WriteLine("Wrong details filled....Please Run it again");
        }
    }
}
