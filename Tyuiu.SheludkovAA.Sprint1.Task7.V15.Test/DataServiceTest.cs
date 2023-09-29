using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint1.Task7.V15.Lib;

namespace Tyuiu.SheludkovAA.Sprint1.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 0.539;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
