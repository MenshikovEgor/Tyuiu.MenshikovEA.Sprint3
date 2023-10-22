using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MenshikovEA.Sprint3.Task3.V28.Lib;

namespace Tyuiu.MenshikovEA.Sprint3.Task3.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("f35hyt t4j 3gkg45");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            char item = 'r';
            string value = "f35hyt t4j 3gkg45";

            Console.WriteLine(ds.ReplaceNumOnChar(value, item));
            Console.ReadKey();
        }
    }
}
