using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayAssesment
{
    internal class PatientException:ApplicationException
    {
        public void InvalidPatientId()
        {
            Console.WriteLine("Invalid Patient Id");
        }

        public void EmptyList()
        {
            Console.WriteLine("Patient List is Empty");
        }
    }
}
