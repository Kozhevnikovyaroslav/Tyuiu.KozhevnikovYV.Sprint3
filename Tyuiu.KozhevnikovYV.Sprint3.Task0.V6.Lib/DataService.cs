namespace Tyuiu.KozhevnikovYV.Sprint3.Task0.V6.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint3;


    public class DataService : ISprint3Task0V6
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double x = 1;
            double multSeries = (1 / Math.Pow((Math.Cos(5) + 1), 2));
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                x *= multSeries;
            }
            return Math.Round(x, 3);
        }
    }
}
