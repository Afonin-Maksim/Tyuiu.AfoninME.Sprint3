using Tyuiu.AfoninME.Sprint3.Task6.V13.Lib;

namespace Tyuiu.AfoninME.Sprint3.Task6.V13.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();

            int startValue = 8, stopValue = 17;
            int res = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreEqual(117, res);
        }
    }
}
