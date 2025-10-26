// See https://aka.ms/new-console-template for more information
using Tyuiu.KozhevnikovYV.Sprint3.Task4.V26.Lib;
DataService ds = new DataService();

Console.Title = "Спринт 3 | Выполнил: Кожевников Я. В. | ПКТб-25-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #3                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
Console.WriteLine("* Задание #4                                                                   *");
Console.WriteLine("* Вариант #26                                                                  *");
Console.WriteLine("* Выполнил: Кожевников Ярослав Вадимович | ПКТб-25-1                           *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение функции  *");
Console.WriteLine("* y=(cos(x)-sin(x))/x При х = 0 пропустить значение.                           *");
Console.WriteLine("*                                                                              *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("y=(cos(x)-sin(x))/x");


int x = -5;
int y = 5;
Console.WriteLine("Старт шага:" + x);
Console.WriteLine("Конец шага:" + y);

Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
Console.WriteLine(ds.Calculate(x, y));