using tyuiu.cources.programming.interfaces.Sprint3;
using System;

namespace Tyuiu.NedelkinFA.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double result = 1; 
            do
            {
                result *= (Math.Pow(2, startValue) / (startValue + 2.0));
                startValue++;
            } while (startValue <= stopValue);
            result *= Math.Cos(1.8);
            result = result / 100000.0;

            return Math.Round(result, 3);
    }
}
