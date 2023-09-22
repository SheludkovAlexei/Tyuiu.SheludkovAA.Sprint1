using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SheludkovAA.Sprint1.Task3.V0.Lib;

namespace Tyuiu.SheludkovAA.Sprint1.Task3.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите длину прямоугольника :                                          *");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите ширину прямоугольника :                                         *");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Площадь прямоугольника равна : " + ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
