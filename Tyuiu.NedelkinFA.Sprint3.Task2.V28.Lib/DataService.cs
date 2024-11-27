using tyuiu.cources.programming.interfaces.Sprint3;
using System;

namespace Tyuiu.NedelkinFA.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double result = 1.0;

            do
            {
                double term = (2.0 * startValue) / (startValue + 1.0);
                result *= term; 
                startValue++;
            } while (startValue <= stopValue);

            result *= -0.001; 
            result *= Math.Cos(1.8); 

            return Math.Round(result, 3);
        }
    }
}
