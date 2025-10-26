// See https://aka.ms/new-console-template for more information
using Tyuiu.KozhevnikovYV.Sprint3.Task1.V7.Lib;
DataService ds = new DataService();

Console.Title = "Спринт 3 | Выполнил: Кожевников Я. В. | ПКТб-25-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #3                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
Console.WriteLine("* Задание #1                                                                   *");
Console.WriteLine("* Вариант #7                                                                   *");
Console.WriteLine("* Выполнил: Кожевников Ярослав Вадимович | ПКТб-25-1                           *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение      *");
Console.WriteLine("* ряда по формуле, при a = 0,25                                                  *");
Console.WriteLine("*                                                                              *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("    9");
Console.WriteLine("  ");
Console.WriteLine("p = П   (a^k + 1)sin(5)");
Console.WriteLine("        ");
Console.WriteLine("   k=1");


double x = 0.25;
int y = 1;
int z = 9;

Console.WriteLine("Старт шага:" + x);
Console.WriteLine("Конец шага:" + y);

Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
Console.WriteLine(ds.GetMultiplySeries(x, y, z));