using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NedelkinFA.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1;
            int k = 1;

            do
            {
                p *= Math.Pow(2, k) / (k + 1);
                k++;
            } while (k <= 9);

            p *= Math.Cos(1.8);
            return Math.Round(p, 3);
        }
    }
}
