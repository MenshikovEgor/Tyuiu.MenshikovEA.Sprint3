using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenhikovEA.Sprint3.Task1.V13.Lib;

namespace Tyuiu.MenhikovEA.Sprint3.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 7;
            double value = 1.2;

            Assert.AreEqual(164.845, ds.GetMultiplySeries(value, startValue, stopValue));
        }
    }
}
