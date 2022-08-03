using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal interface DetailsInterface
    {
        dynamic AddStudent(dynamic student);
        dynamic SpecificDetails(dynamic arr);
        void UpdateDetails(dynamic arr);
        dynamic DeleteDetails(dynamic arr);
    }
}
