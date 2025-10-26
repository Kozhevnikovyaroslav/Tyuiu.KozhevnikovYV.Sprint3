// See https://aka.ms/new-console-template for more information
using Tyuiu.KozhevnikovYV.Sprint3.Task0.V6.Lib;
DataService ds = new DataService();

Console.Title = "Спринт 3 | Выполнил: Кожевников Я. В. | ПКТб-25-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #3                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
Console.WriteLine("* Задание #0                                                                   *");
Console.WriteLine("* Вариант #6                                                                   *");
Console.WriteLine("* Выполнил: Кожевников Ярослав Вадимович | ПКТб-25-1                           *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение        *");
Console.WriteLine("* ряда по формуле                                                             *");
Console.WriteLine("*                                                                              *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("   15");
Console.WriteLine("                1");
Console.WriteLine("p = П   ----------------");
Console.WriteLine("        (cos(5) + 1))^2");
Console.WriteLine("   k=1");


int x = 1;
int y = 15;

Console.WriteLine("Старт шага:" + x);
Console.WriteLine("Конец шага:" + y);

Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
Console.WriteLine(ds.GetMultiplySeries(x, y));