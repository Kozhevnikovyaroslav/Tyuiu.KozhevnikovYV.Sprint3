namespace Tyuiu.KozhevnikovYV.Sprint3.Task6.V7.Lib
{
    using tyuiu.cources.programming.interfaces.Sprint3;
    public class DataService : ISprint3Task6V7
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int d = 1; d <= i; d++)
                {
                    if (i % d == 0)
                    {
                        sum += d;
                    }
                }
            }
            return sum;
        }
    }
}
