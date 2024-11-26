using Tyuiu.NedelkinFA.Sprint3.Task1.V8.Lib;
namespace Tyuiu.NedelkinFA.Sprint3.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 5;
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 8687915.945;
            Assert.AreEqual(wait, res);
        }
    }
}