using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MenshikovEA.Sprint3.Task0.V14.Lib
{
    public class DataService : ISprint3Task0V14
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res2 = 0;
            for (int k = startValue; k <= stopValue; k++)
            {
                double res = Math.Pow((1/(Math.Pow(k, value))), -1);
                res2 += res;
            }

            return res2;
        }
    }
}
