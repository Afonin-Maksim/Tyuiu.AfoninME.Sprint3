using Tyuiu.AfoninME.Sprint3.Task2.V27.Lib;

namespace Tyuiu.AfoninME.Sprint3.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 14;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 0.69;
            Assert.AreEqual(wait, res);


        }

    }
}
