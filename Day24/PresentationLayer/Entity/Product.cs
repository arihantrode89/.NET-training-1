using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productID, string productName, float price)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
        }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public int CategoryId { get; set; }


    }
}
