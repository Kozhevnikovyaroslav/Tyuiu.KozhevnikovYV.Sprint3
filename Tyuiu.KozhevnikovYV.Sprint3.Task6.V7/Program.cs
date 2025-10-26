// See https://aka.ms/new-console-template for more information
using Tyuiu.KozhevnikovYV.Sprint3.Task6.V7.Lib;
DataService ds = new DataService();

Console.Title = "Спринт 3 | Выполнил: Кожевников Я. В. | ПКТб-25-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #3                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
Console.WriteLine("* Задание #6                                                                   *");
Console.WriteLine("* Вариант #7                                                                   *");
Console.WriteLine("* Выполнил: Кожевников Ярослав Вадимович | ПКТб-25-1                           *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих            *");
Console.WriteLine("* числовому отрезку [17, 26] сумму всех делителей.                             *");
Console.WriteLine("*                                                                              *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");

int x = 17;
int y = 26;
Console.WriteLine("Старт шага:" + x);
Console.WriteLine("Конец шага:" + y);

Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
Console.WriteLine(ds.GetSumTheDivisors(x, y));