using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint1.Task3.V15.Lib;

namespace Tyuiu.SheludkovAA.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            DataService ds = new DataService();
            double t = 2;
            double v1 = 15;
            double v2 = 10;
            double s = 50;
            var wait = 100;
            var res = ds.DistanceOverTime(v1, v2, s, t);
            Assert.AreEqual(wait, res);
        }
    }
}
