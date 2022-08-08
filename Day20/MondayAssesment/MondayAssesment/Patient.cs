using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayAssesment
{
    internal class  Patient
    {
        string _id,_name, _address, _disease, _doctor_in_charge, _room_no;
        byte _age;


        public Patient()
        {

        }
        public Patient(string name, string address, string disease, string doctor_in_charge, string room_no, byte age)
        {
            Name = name;
            Address = address;
            Disease = disease;
            Age = age;
            DoctorInCharge = doctor_in_charge;
            Room = room_no;
            _id = GenerateId();
        }

        public byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public string Disease
        {
            get
            {
                return _disease;
            }
            set
            {
                _disease = value;
            }
        }

        public string DoctorInCharge
        {
            get
            {
                return _doctor_in_charge;
            }
            set
            {
                _doctor_in_charge = value;
            }
        }

        public string Room
        {
            get
            {
                return _room_no;
            }
            set
            {
                _room_no = value;
            }
        }

        public string Id
        {
            get
            {
                return _id;
            }
        }
        public string GenerateId()
        {
            return Name.Substring(0,2) + Room.Substring(2);
        }

    }
}
