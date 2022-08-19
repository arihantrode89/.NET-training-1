using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Student
    {
        int _id;
        string _firstname, _email, _phone, _dept,_password,_lastname;

        public int Id { get { return _id; } set { _id = value; } }
        public string FirstName { get { return _firstname; } set { _firstname = value; } }

        public string Email { get { return _email; } set { _email = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }
        public string Dept{get { return _dept; }set { _dept = value; }}

        public string LastName { get { return _lastname; } set { _lastname = value; } }
        public string Password { get { return _password; } set { _password = value; } }

    }
}
