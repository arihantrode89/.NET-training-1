using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskCodeApproach.Controllers;
using System.Web;
using System.Web.Mvc;

namespace WebUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ProductController productController = new ProductController();
            ViewResult data = productController.Index() as ViewResult;

            Assert.AreEqual("Index",data.ViewName);
        }
    }
}
