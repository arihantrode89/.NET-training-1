using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    
    partial class Partial1
    {

        string _name,_role,_gender;
        int _id;
        
        //public Partial1(string name,string role, int id)
        //{
        //    this._name = name;
        //    this._role = role;
        //    this._id = id;
        //}

        public String Name 
        { 
            get 
            { 
                return this._name;
            } 
            set
            { 
                this._name = value;
            } 
        }

        public String Role
        {
            get
            {
                return this._role;
            }
            set
            {
                this._role = value;
            }
        }

        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        public string Gender
        {
            get
            {
                return this._gender;
            }
            set
            {
                this._gender = value;
            }
        }
    }
}
