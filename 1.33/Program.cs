using System;
double people, area;
Console.WriteLine("Ввидите число насиления");
people = int.Parse(Console.ReadLine());
Console.WriteLine("Ввидите площадь страны");
area = int.Parse(Console.ReadLine());//  ввод значений
double result;
result = people / area;
Console.WriteLine(" Ответ {0} на км в квадрате",result);
