using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskCodeApproach.Models;
using TaskCodeApproach.ViewModel;

namespace TaskCodeApproach.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product ptd)
        {
            var db = new ProductContext();
            db.Database.ExecuteSqlCommand($"InsertProduct '{ptd.ProductName}',{ptd.Price},{ptd.CategoryId}");
            return Redirect("~/Product/GetProducts");
        }

        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category ctg)
        {
            var db = new ProductContext();
            db.Database.ExecuteSqlCommand($"InsertCategory '{ctg.CategoryName}'");
            return Redirect("~/Product/GetProducts");
        }

        public ActionResult GetProducts()
        {
            var db = new ProductContext();
            var data = db.Products.ToList();
            var sql = db.Sp_GetProducts();
            //var sql = db.Database.SqlQuery<ProductCategory>("GetProducts").ToList();
            //var linq = from p in db.Products.ToList() join q in db.Categories.ToList() on p.CategoryId equals q.CategoryId
            //           into table1
            //           select table1.ToList();

            return View(sql);   
        }

        public ActionResult GetCategory()
        {
            var db = new ProductContext();

            return View(db.Categories.ToList());
        }

        public ActionResult ProductByCategory(int id)
        {
            var db = new ProductContext();
            var data = db.Products.Where(s => s.CategoryId == id).ToList();
            return View("GetProducts", data);
        }
        public ActionResult GetSingleProduct(int id)
        {
            var db = new ProductContext();
            var data = db.Products.Where(w => w.ProductId == id).FirstOrDefault();
            return View(data);
        }

        public ActionResult UpdateProduct(int id)
        {
            var db = new ProductContext();

            return View(db.Products.Where(s => s.ProductId == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product ptd)
        {
            var db = new ProductContext();
            db.Database.ExecuteSqlCommand($"UpdateProduct {ptd.ProductId},'{ptd.ProductName}',{ptd.Price},{ptd.CategoryId}");
            return Redirect("~/Product/GetProducts");
        }

        public ActionResult DeleteProduct(int id)
        {
            var db = new ProductContext();
            db.Database.ExecuteSqlCommand($"DeleteProduct {id}");
            return Redirect("~/Product/GetProducts");
        }
    }
}