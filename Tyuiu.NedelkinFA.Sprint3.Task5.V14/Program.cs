using Tyuiu.NedelkinFA.Sprint3.Task5.V14.Lib;

DataService ds = new DataService();
int x = 5;
int startValue1 = 1;
int stopValue1 = 3;
int startValue2 = 1; 
int stopValue2 = 14;
Console.WriteLine("x = " + x);
Console.WriteLine("start 1 = " + startValue1);
Console.WriteLine("end 1 = " + stopValue1);
Console.WriteLine("start 2 = " + startValue2);
Console.WriteLine("end 2 = " + stopValue2);
Console.WriteLine("sum = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
Console.ReadKey();
