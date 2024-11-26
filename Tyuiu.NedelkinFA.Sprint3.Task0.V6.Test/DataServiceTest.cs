using Tyuiu.NedelkinFA.Sprint3.Task0.V6.Lib;

namespace Tyuiu.NedelkinFA.Sprint3.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 15;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
