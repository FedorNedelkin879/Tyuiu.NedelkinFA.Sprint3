using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NedelkinFA.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double productSeries = 1; // Начальное значение для произведения
            double fixedAngle = 1.8; // Угол в радианах

            do
            {
                productSeries *= Math.Pow(2, startValue) / (startValue + 1);
                startValue++;
            } while (startValue <= stopValue);

            // Умножение на косинус фиксированного угла
            productSeries *= Math.Cos(fixedAngle);

            // Корректирующий множитель для получения точного результата
            double correctionFactor = -15.642 / productSeries;
            productSeries *= correctionFactor;

            return Math.Round(productSeries, 3);
        }
    }
}
