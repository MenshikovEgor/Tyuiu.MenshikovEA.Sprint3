using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MenshikovEA.Sprint3.Task6.V13.Lib
{
    public class DataService : ISprint3Task6V13
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            double x;
            int sum = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int d = 9; d <= x; d++)
                {
                    if ( x % d == 0)
                    {
                        sum += d;
                    }
                }
            }
            return sum;
        }
    }
}
