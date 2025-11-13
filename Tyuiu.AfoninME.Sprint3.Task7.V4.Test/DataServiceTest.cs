using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AfoninME.Sprint3.Task7.V4.Lib;

namespace Tyuiu.AfoninME.Sprint3.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            var ds = new DataService();
            int start = -5;
            int stop = 5;

            double[] result = ds.GetMassFunction(start, stop);
            Assert.AreEqual(11, result.Length);
            Assert.AreEqual(-2.15, result[0], 0.01);
            Assert.AreEqual(3, result[5], 0.01);
            Assert.AreEqual(0.03, result[10], 0.01);
        }
    }
}