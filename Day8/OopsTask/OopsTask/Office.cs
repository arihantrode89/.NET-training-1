using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsTask
{

    class HrManagement
    {
        
        public enum location
        {
            Nagpur,Noida,Bangalore,Delhi,Pune
        }
        public void Manage()
        {
            Console.WriteLine("I'm managing");
        }

        
    }
    
    class Employee:HrManagement
    {
        public string _name, _email,_location,_project,_pri_skill;
        public int _id;
       
        public String Name { get { return _name; } set { _name = value; } }

        public int Id { get { return _id; } set { _id = value; } }

        public String PriSkill { get { return _pri_skill; } set { _pri_skill = value; } }

        public String Email { get { return _email; } set { _email = value; } }

        public String Location { get { return _location; } set { _location = value; } }

        public String Project { get { return _project; } set { _project = value; } }



        public void Working()
        {
            Console.WriteLine("I'm working");
        }
        public void ShowWork()
        {
            Console.WriteLine($"My Project is on {Project}");
        }

        public void Display()
        {
            Console.WriteLine($"Id:{Id}\nName:{Name}\nEmail:{Email}\nLocation:{Location}\nProject:{Project}\nPreSkill:{PriSkill}");
        }

    }

    class Department:HrManagement
    {
        private Array ongoing_project = Array.CreateInstance(typeof(string), 5);

        
        public void AddProj()
        {
            Console.WriteLine("Enter Ongoing project name with its Skill divided by underscore(_)");
            for(int i = 0; i < ongoing_project.Length; i++)
            {
                    var a = Console.ReadLine();
                    ongoing_project.SetValue(a,i);
           
            }
        }
        public void Location(Employee obj)
        {
            obj.Location = location.Nagpur.ToString();
        }
        public void SetWork(Employee obj)
        {
            if(obj.PriSkill == "C#")
            {
                foreach(string item in ongoing_project)
                {
                    if(item.Contains(obj.PriSkill))
                    {
                        var proj = item.Split('_');
                        obj.Project = proj.GetValue(0).ToString();
                    }
                }
            
            } 
            else if(obj.PriSkill == "Python")
            {
                foreach (string item in ongoing_project)
                {
                    if (item.Contains(obj.PriSkill))
                    {
                        var proj = item.Split('_');
                        obj.Project = proj.GetValue(0).ToString();
                    }
                }

            }
        }

    }

 

}
