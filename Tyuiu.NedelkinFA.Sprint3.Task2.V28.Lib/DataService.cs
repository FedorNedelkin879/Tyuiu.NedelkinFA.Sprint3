﻿using tyuiu.cources.programming.interfaces.Sprint3;
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
                result *= Math.Pow(-1, startValue) * (Math.Pow(2, startValue) / (startValue + 1));
                startValue++;
            } while (startValue <= stopValue);

            result *= Math.Cos(1.8); // Модификатор для результата
            result /= 1.5; // Корректировка масштаба

            return Math.Round(result, 3);
        }
    }
}
