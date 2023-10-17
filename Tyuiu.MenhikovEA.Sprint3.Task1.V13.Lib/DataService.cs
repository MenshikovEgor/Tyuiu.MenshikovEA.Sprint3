using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MenhikovEA.Sprint3.Task1.V13.Lib
{
    public class DataService : ISprint3Task1V13
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double res2 = 1;
            while ( startValue <= stopValue)
            {
                double res = Math.Pow((1 / (Math.Pow(value, startValue))), -1);
                res2 = res2 * res;
                startValue++;
            }
            double resF = Math.Round(res2, 3);

            return resF;
        }
    }
}
