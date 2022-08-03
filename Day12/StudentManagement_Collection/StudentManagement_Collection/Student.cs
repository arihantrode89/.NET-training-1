using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_Collection
{
    internal class Student
    {
        int _id;
        float _obtainedmarks, _totalmarks;
        string _name, _address;

        
        public Student(int id, string name, string address, float Totalmarks, float ObtainedMarks)
        {
            this.Id = id;
            this.ObtainedMarks = ObtainedMarks;
            this.Name = name;
            this.Address = address;
            this.TotalMarks = Totalmarks;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public float TotalMarks { get { return _totalmarks; } set { _totalmarks = value; } }
        public float ObtainedMarks { get { return _obtainedmarks; } set { _obtainedmarks = value; } }

        public string Name { get { return _name; } set { _name = value; } }
        public string Address { get { return _address; } set { _address = value; } }
    }
}
