using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Employee
    {
        public Employee()
        {

        }

        public Employee(string Name,string Phone,string Email,string Role,string Dob,char Gender)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
            this.Role = Role;
            this.Dob = Dob;
            this.Gender = Gender;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Dob { get; set; }
        public char Gender { get; set; }
    }
}
