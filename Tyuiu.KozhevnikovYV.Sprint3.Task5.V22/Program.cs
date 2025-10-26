// See https://aka.ms/new-console-template for more information
using Tyuiu.KozhevnikovYV.Sprint3.Task5.V22.Lib;
DataService ds = new DataService();

Console.Title = "Спринт 3 | Выполнил: Кожевников Я. В. | ПКТб-25-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #3                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
Console.WriteLine("* Задание #5                                                                   *");
Console.WriteLine("* Вариант #22                                                                  *");
Console.WriteLine("* Выполнил: Кожевников Ярослав Вадимович | ПКТб-25-1                           *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* Вычислить произведение по заданной формуле                                   *");
Console.WriteLine("*                                                                              *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("    3     12");
Console.WriteLine("                           ");
Console.WriteLine("y = E      E     (x^3 * sin(k)) + 2");
Console.WriteLine("                       ");
Console.WriteLine("   i=1    k=1");



int x = 2;
int y = 1;
int z = 1;
int l = 3;
int r = 12;
Console.WriteLine("Старт первого шага:" + y);
Console.WriteLine("Старт второго шага:" + z);
Console.WriteLine("Конец первого шага:" + l);
Console.WriteLine("Старт второго шага:" + r);

Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
Console.WriteLine(ds.GetSumSumSeries(x, y,z,l,r));