﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_event_revise
{
    public delegate void NameChangeDelegate(string oldname,string newname);
    public class Subscriber
    {
        public string SubscriberId;
        public Employee Emp = null;
        public NameChangeDelegate ndel = null;
        
        public Subscriber(string subid,Employee emp)
        {
            SubscriberId = subid;
            Emp = emp;
            //ndel += NameChangeMethod;
            //Emp.OnNameChanged += ndel;
            Emp.OnNameChanged += NameChangeMethod;


        }
        

        public void NameChangeMethod(string old,string newname)
        {
            Console.WriteLine($"Employee Name change from {old} to {newname}");
        }

        public void Unsubscribe()
        {
            Emp.OnNameChanged -= NameChangeMethod;
            //Emp.OnNameChanged -= ndel;
        }
        

    }
    public class Employee
    {
        string firstname="Akshay";
        string lastname;

        public event NameChangeDelegate OnNameChange;

        public event NameChangeDelegate OnNameChanged
        {
            add
            {
                OnNameChange += value;
                if(value.Target is Subscriber)
                {
                    Console.WriteLine($"{((Subscriber)value.Target).SubscriberId} is just subscirbed to OnNameChanged event");
                }
            }
            remove
            {
                OnNameChange -= value;
                if (value.Target is Subscriber)
                {
                    Console.WriteLine($"{((Subscriber)value.Target).SubscriberId} is just unsubscirbed to OnNameChanged event");
                }
            }
        }
        public string FirstName
        {
            get { return firstname; }
            set
            {
                OnNameChange(firstname, value);
                firstname = value;
                
            }
        }
        public string LastName
        {
            get { return LastName; } 
            set 
            { 
                LastName = value; 
            } 
        }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Subscriber s1 = new Subscriber("s-101", emp);
            Subscriber s2 = new Subscriber("s-102", emp);
            Subscriber s3 = new Subscriber("s-103", emp);

            emp.FirstName = "Arihant";

            s2.Unsubscribe();

            emp.FirstName = "A";
        }
    }
}
