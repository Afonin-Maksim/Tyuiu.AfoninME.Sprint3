using Tyuiu.AfoninME.Sprint3.Task4.V7.Lib;

namespace Tyuiu.AfoninME.Sprint3.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 1231.420;
            Assert.AreEqual(res, wait);
        }
    }
}
