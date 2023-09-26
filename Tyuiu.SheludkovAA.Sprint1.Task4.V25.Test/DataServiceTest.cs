using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint1.Task4.V25.Lib;

namespace Tyuiu.SheludkovAA.Sprint1.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.017;
            double wait = 0.5;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
