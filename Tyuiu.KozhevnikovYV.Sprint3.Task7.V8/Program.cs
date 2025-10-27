// See https://aka.ms/new-console-template for more information
using Tyuiu.KozhevnikovYV.Sprint3.Task7.V8.Lib;
DataService ds = new DataService();
int x = -5;
int y = 5;
string str ="";
double[] res = ds.GetMassFunction(x, y);
for(int i = 0; i < res.Length; i++)
{
    str+=(res[i] + " ");
}
str = str.Remove(str.Length - 1);
str = str.Remove(str.Length - 1);
Console.WriteLine(str);
