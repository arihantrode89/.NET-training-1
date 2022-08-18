using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ObjectDataSource_ControlsDemo
{
    public class Author
    {
        public Author()
        {

        }

        public Author(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
    }
}