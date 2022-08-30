using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskCodeApproach.ViewModel
{
    public class ProductCategory
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}