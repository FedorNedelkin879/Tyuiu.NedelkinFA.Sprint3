using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NedelkinFA.Sprint3.Task0.V6.Lib
{
    public class DataService : ISprint3Task0V6
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double productSeries = 1;
            for (int k = startValue; k <= stopValue; k++)
            {
                productSeries *= Math.Pow(1 / (Math.Cos(5) + 1), 2);
            }
            return Math.Round(productSeries, 3);
        }
    }
}
