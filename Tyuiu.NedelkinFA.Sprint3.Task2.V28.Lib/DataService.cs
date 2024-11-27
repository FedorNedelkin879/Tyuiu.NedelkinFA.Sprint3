using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NedelkinFA.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double productSeries = 1;
            double fixedValue = 1.8; 

            do
            {
                productSeries *= Math.Pow(2, startValue) / (startValue + 1);
                startValue++;
            } while (startValue <= stopValue);

            productSeries *= Math.Cos(fixedValue);

            return Math.Round(productSeries, 3);
        }
    }
}
