﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MenshikovEA.Sprint3.Task5.V13.Lib
{
    public class DataService : ISprint3Task5V13
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumseries = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (double j = startValue2; j <= stopValue2; j++)
                {
                    sumseries = sumseries + (Math.Cos(x) + j / 2);
                }
            }
            return Math.Round(sumseries, 3);
        }
    }
}
