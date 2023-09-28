﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint1.Task6.V0.Lib;

namespace Tyuiu.SheludkovAA.Sprint1.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string strTest = "1 * 2 * 3";
            string res = ds.WorkWithText(strTest);
            string wait = "123";
            Assert.AreEqual(wait, res);
        }
    }
}
