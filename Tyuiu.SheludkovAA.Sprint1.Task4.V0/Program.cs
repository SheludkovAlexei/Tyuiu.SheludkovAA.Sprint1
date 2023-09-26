using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SheludkovAA.Sprint1.Task4.V0.Lib;

namespace Tyuiu.SheludkovAA.Sprint1.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите значение x:                                                     *");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите значение y:                                                     *");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("1 / (x^2 + y^2) = " + ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
