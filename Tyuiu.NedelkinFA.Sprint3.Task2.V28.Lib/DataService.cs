using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NedelkinFA.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double result = 1.0; 
            do
            {
                result *= (1 / Math.Sin(startValue)) + 2.5;
                startValue++;
            } while (startValue <= stopValue);

            return Math.Round(result, 3);
        }
    }
}
