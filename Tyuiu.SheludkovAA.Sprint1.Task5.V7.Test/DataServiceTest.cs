using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.SheludkovAA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            DataService ds = new DataService();
            double f = 60;
            var res = ds.AngleToHoursMinutes(f);
            var wait = 2;
            Assert.AreEqual(wait, res);

        }
    }
}
