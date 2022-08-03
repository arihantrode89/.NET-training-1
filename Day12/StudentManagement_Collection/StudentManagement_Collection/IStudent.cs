using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_Collection
{
    internal interface IStudent
    {
        void AddStudent(int id, string name, string address, float Totalmarks, float ObtainedMarks);
        Student SpecificStudent(int id);
        Boolean UpdateDetails(int id);
        Boolean DeleteDetails(int id);
        void ShowDetails();
        void DisplaySpecificDetail(int id);
    }
}
