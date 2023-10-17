using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MenhikovEA.Sprint3.Task1.V13.Lib;

namespace Tyuiu.MenhikovEA.Sprint3.Task1.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startvalue = 1;
            int stopvalue = 7;
            double value = 1.2;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("k = 1, k <= 7, n = 1.2");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.GetMultiplySeries(value, startvalue, stopvalue);

            Console.WriteLine("Результат произведения: " + res);
            Console.ReadKey();
        }
    }
}
