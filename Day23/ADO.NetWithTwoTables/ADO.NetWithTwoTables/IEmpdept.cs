using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetWithTwoTables
{
    internal interface IEmpdept
    {
        void AddEmployee(int Id, string Name, long Phone, string Email, string Role, string Dob, char Gender, char Band, string Grade, float Sal, string Doj, string Dept);

        void AddDepartment(string dept_name, string location);
        bool UpdateEmployee(int id);
        bool DeleteDetails(int id);
        void ShowDetails();
        bool ShowSpecificDetails(int id);
    }
}
