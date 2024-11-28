using Tyuiu.NedelkinFA.Sprint3.Task5.V14.Lib;

namespace Tyuiu.NedelkinFA.Sprint3.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 5;
            int startValue2 = 1;
            int stopValue2 = 10;
            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);
            double wait = 282.762;
            Assert.AreEqual(res, wait);
        }
    }
}