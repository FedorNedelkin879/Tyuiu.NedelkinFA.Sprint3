using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NedelkinFA.Sprint3.Task5.V14.Lib
{
    public class DataService : ISprint3Task5V14
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            int i, j;
            for (i = startValue1; i <= stopValue1; i++)  // Внешний цикл по i
            {
                for (j = startValue2; j <= stopValue2; j++)  // Внутренний цикл по j
                {
                    // Используем модифицированную формулу: (1 / sin(j)) + x
                    sumSeries += (1 / Math.Sin(j)) + x;
                }
            }
            return Math.Round(sumSeries, 3);  // Округляем результат
        }
    }
}
