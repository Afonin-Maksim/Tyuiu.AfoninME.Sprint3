using Tyuiu.AfoninME.Sprint3.Task3.V14.Lib;

namespace Tyuiu.AfoninME.Sprint3.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string Value = "ddd";
            char replaceable = 'd';
            char replacement = '’';
            string res = ds.ReplaceCharInString(Value, replaceable, replacement);
            string wait = "’’’";
            Assert.AreEqual(wait, res);
        }
    }
}
