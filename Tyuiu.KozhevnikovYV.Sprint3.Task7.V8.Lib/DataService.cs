namespace Tyuiu.KozhevnikovYV.Sprint3.Task7.V8.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint3;
    public class DataService : ISprint3Task7V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int x;
            int count = 0;
            double[] array = new double[stopValue - startValue + 1];
            for (x = startValue; x <= stopValue; x ++)
            {
                if (x == 2)
                {
                    array[count] = 0;
                }
                else
                {
                    double value = Math.Sin(x) + (Math.Cos(x) + 1) / (2 - x) + 2 * x;
                    array[count] = Math.Round(value, 2);
                }
                count++;
            }
            return array;
        }
    }
}
