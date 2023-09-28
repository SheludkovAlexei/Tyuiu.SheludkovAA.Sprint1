using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint1.Task6.V8.Lib;

namespace Tyuiu.SheludkovAA.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string v = "e2345";
            string res = ds.MoveLetterToEnd(v);
            string wait = "2345e";
            Assert.AreEqual(wait, res);
        }
    }
}
