using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MenshikovEA.Sprint3.Task2.V11.Lib;

namespace Tyuiu.MenshikovEA.Sprint3.Task2.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startvalue = 1;
            int stopvalue = 15;
            double value = 0.5;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("i = 1, i <= 15, x = 0,5");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.GetSumSeries(value, startvalue, stopvalue);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
