// See https://aka.ms/new-console-template for more information
using Tyuiu.KozhevnikovYV.Sprint3.Task2.V1.Lib;
DataService ds = new DataService();

Console.Title = "Спринт 3 | Выполнил: Кожевников Я. В. | ПКТб-25-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #3                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
Console.WriteLine("* Задание #2                                                                   *");
Console.WriteLine("* Вариант #1                                                                   *");
Console.WriteLine("* Выполнил: Кожевников Ярослав Вадимович | ПКТб-25-1                           *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму        *");
Console.WriteLine("* ряда по формуле                                                              *");
Console.WriteLine("*                                                                              *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("    10");
Console.WriteLine("  ");
Console.WriteLine("p = E   sin i * (1/2)^2");
Console.WriteLine("        ");
Console.WriteLine("   k=1");


int x = 1;
int y = 10;

Console.WriteLine("Старт шага:" + x);
Console.WriteLine("Конец шага:" + y);

Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
Console.WriteLine(ds.GetSumSeries(x, y));