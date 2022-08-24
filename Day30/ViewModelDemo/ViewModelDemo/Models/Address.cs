using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModelDemo.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
    }
}