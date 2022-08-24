using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewDemo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public string ProductCategory { get; set; }
        public float Price { get; set; }

    }
}