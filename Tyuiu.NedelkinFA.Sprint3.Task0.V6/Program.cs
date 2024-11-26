using Tyuiu.NedelkinFA.Sprint3.Task0.V6.Lib;

DataService ds = new DataService();
double value = 5;
int startValue = 1;
int stopValue = 10;
Console.WriteLine("x = " + value);
Console.WriteLine("start" + startValue);
Console.WriteLine("stop" + stopValue);
Console.WriteLine("сумма ряда " + ds.GetSumSeries(value, startValue, stopValue));
Console.ReadKey();