using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint1.Task5.V0.Lib;

namespace Tyuiu.SheludkovAA.Sprint1.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            DataService ds = new DataService();
            double x = 4;
            double res = ds.Calculate(x);
            int wait = 8;
            int result = Convert.ToInt32(res);
            Assert.AreEqual(wait, result);
        }
    }
}
