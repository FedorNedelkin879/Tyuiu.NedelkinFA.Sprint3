﻿using Tyuiu.NedelkinFA.Sprint3.Task2.V28.Lib;

DataService ds = new DataService();
int startValue = 1; // Начальное значение
int stopValue = 9;  // Конечное значение
Console.WriteLine("start = " + startValue);
Console.WriteLine("stop = " + stopValue);
Console.WriteLine("произведение ряда = " + ds.GetMultiplySeries(startValue, stopValue));
Console.ReadKey();
