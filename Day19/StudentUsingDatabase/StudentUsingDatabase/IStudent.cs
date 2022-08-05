using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentUsingDatabase
{
    internal interface IStudent
    {
        void AddStudentDetails(int id, string name, string address, float Totalmarks, float ObtainedMarks);
        bool UpdateStudent(int id);
        bool DeleteDetails(int id);
        void ShowDetails();
        bool ShowSpecificDetails(int id);

    }
}
