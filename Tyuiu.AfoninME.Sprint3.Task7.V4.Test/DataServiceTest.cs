using Tyuiu.AfoninME.Sprint3.Task7.V4.Lib;

namespace Tyuiu.AfoninME.Sprint3.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            var ds = new DataService();

            int start = -5;
            int stop = 5;

            double[] result = ds.GetMassFunction(start, stop);

            
            Assert.AreEqual(11, result.Length);
        }
    }
}
