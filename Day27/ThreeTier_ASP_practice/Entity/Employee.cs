using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Employee
    {
        int _id;
        string _name, _phone, _email, _role, _dob;
        char _gender;

        public Employee()
        {

        }

        public Employee(string name,string phone,string email,string role,string dob,char gender)
        {
            Name=name;
            Phone=phone;
            Email=email;
            Role=role;
            DateofBirth = dob;
            Gender=gender;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Phone{get { return _phone; } set { _phone = value; } }
        public char Gender { get { return _gender; } set { _gender = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Role { get { return _role; } set { _role = value; } }
        public string DateofBirth { get { return _dob; } set { _dob = value; } }

    }
}
