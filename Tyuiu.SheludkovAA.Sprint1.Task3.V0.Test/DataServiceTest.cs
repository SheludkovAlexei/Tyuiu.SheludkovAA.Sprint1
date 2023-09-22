using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint1.Task3.V0.Lib;

namespace Tyuiu.SheludkovAA.Sprint1.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(50, res);
        }
    }
}
