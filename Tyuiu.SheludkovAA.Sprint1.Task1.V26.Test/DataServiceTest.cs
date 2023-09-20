using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint1.Task1.V26.Lib;

namespace Tyuiu.SheludkovAA.Sprint1.Task1.V26.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double x = 4.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(5, res);
        }
    }
}
