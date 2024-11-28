using Tyuiu.NedelkinFA.Sprint3.Task6.V10.Lib;

namespace Tyuiu.NedelkinFA.Sprint3.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 10;
            int stopValue = 15;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 120;
            Assert.AreEqual(wait, res);
        }
    }
}