using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Department
    {
        public Department()
        {

        }
        public Department(string Dept_Name,string Location)
        {
            this.Dept_Name = Dept_Name;
            this.Location = Location;
        }

        public string Dept_Name { get; set; }
        public string Location { get; set; }
    }
}
