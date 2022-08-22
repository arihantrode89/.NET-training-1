using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestDemo;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Program obj = new Program();

        [TestMethod]
        public void TestMethod1()
        {
            var num = obj.Add(10,20);
            Assert.AreEqual(30,num);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var num = obj.Subtract(20, 10);
            Assert.AreEqual(10,num);
        }
    }
}
