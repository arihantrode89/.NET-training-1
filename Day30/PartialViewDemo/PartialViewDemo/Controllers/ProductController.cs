using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewDemo.Models;

namespace PartialViewDemo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){Id=1,ProductName="P1",ProductDescription="D1",ProductCategory="C1",Price=10.0f},
                new Product(){Id=2,ProductName="P2",ProductDescription="D2",ProductCategory="C2",Price=20.0f},
                new Product(){Id=3,ProductName="P3",ProductDescription="D3",ProductCategory="C3",Price=30.0f},
                new Product(){Id=4,ProductName="P4",ProductDescription="D4",ProductCategory="C4",Price=40.0f},
                new Product(){Id=5,ProductName="P5",ProductDescription="D5",ProductCategory="C5",Price=50.0f},
            };
            return View(products);
        }

        public PartialViewResult ProductPartial()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){Id=1,ProductName="P1",ProductDescription="D1",ProductCategory="C1",Price=10.0f},
                new Product(){Id=2,ProductName="P2",ProductDescription="D2",ProductCategory="C2",Price=20.0f},
                new Product(){Id=3,ProductName="P3",ProductDescription="D3",ProductCategory="C3",Price=30.0f},
                new Product(){Id=4,ProductName="P4",ProductDescription="D4",ProductCategory="C4",Price=40.0f},
                new Product(){Id=5,ProductName="P5",ProductDescription="D5",ProductCategory="C5",Price=50.0f},
            };

            return PartialView("ProductPartial",products.GetRange(0,2));
        }

        public PartialViewResult SingleProduct()
        {
            Product ptd = new Product() { Id = 1, ProductName = "P1", ProductDescription = "D1", ProductCategory = "C1", Price = 10.0f };
            return PartialView("SingleProduct",ptd);
        }
    }
}