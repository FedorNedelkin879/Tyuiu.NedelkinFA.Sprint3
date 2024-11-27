using Tyuiu.NedelkinFA.Sprint3.Task2.V28.Lib;

DataService ds = new DataService();
int startValue = 1;
int stopValue = 9;
Console.WriteLine("start" + startValue);
Console.WriteLine("stop" + stopValue);
Console.WriteLine("сумма ряда " + ds.GetMultiplySeries(startValue, stopValue));
Console.ReadKey();