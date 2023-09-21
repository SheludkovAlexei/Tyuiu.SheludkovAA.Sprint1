using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint1.Task2.V13.Lib;

namespace Tyuiu.SheludkovAA.Sprint1.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            DataService ds = new DataService();
            int x = 10;
            var res = ds.ConvertMilesToKm(x);
            Assert.AreEqual(16.09344, res);
        }
    }
}
