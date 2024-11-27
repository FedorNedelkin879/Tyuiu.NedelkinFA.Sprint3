using Tyuiu.NedelkinFA.Sprint3.Task3.V17.Lib;

namespace Tyuiu.NedelkinFA.Sprint3.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();
            string value = "*vn98n! b,";
            int res = ds.ConvertStringToInt(value);
            int wait = 98;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidConvertStringToInt_EmptyResult()
        {
            DataService ds = new DataService();
            string value = "abc!@#";
            int res = ds.ConvertStringToInt(value);
            int wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}
