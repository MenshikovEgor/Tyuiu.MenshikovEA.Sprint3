using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint3.Task6.V13.Lib;

namespace Tyuiu.MenshikovEA.Sprint3.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int res = ds.GetSumTheDivisors(8, 17);
            Assert.AreEqual(117, res);
        }
    }
}
