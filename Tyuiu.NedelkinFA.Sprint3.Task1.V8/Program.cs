using Tyuiu.NedelkinFA.Sprint3.Task1.V8.Lib;

DataService ds = new DataService();
double value = 5;
int startValue = 1;
int stopValue = 10;
Console.WriteLine("x = " + value);
Console.WriteLine("start" + startValue);
Console.WriteLine("stop" + stopValue);
Console.WriteLine("сумма ряда " + ds.GetMultiplySeries(value, startValue, stopValue));
Console.ReadKey();