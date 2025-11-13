using Tyuiu.AfoninME.Sprint3.Task7.V4.Lib;

namespace Tyuiu.AfoninME.Sprint3.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = 2;
            valueWaitArray[1] = 1;
            valueWaitArray[2] = 1;
            valueWaitArray[3] = 1;
            valueWaitArray[4] = 1;
            valueWaitArray[5] = 1;
            valueWaitArray[6] = 1;
            valueWaitArray[7] = 1;
            valueWaitArray[8] = 1;
            valueWaitArray[9] = 1;
            valueWaitArray[10] = 1;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}