namespace Tyuiu.KozhevnikovYV.Sprint3.Task3.V2.Lib
{
    using System;
    using System.Reflection.Metadata.Ecma335;
    using tyuiu.cources.programming.interfaces.Sprint3;
    public class DataService : ISprint3Task3V2
    {
        public int GetMaxCharCount(string value, char item)
        {
            int count = 0;
            char lastchr = '0';
            foreach (char chr in value)
            {
                if (lastchr == 'z' && chr == 'z')
                {
                    count++;
                }
                lastchr = chr;
            }
            return count;
        }
       
    }
}
