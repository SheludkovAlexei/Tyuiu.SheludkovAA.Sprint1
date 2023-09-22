using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SheludkovAA.Sprint1.Task3.V15.Lib;

namespace Tyuiu.SheludkovAA.Sprint1.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Шелудков А. А. | АСОиУб-23-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Шелудков А. А. | АСОиУб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите скорость первого автомобиля:                                    *");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите скорость второго автомобиля:                                    *");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите расстояние между автомобилями:                                  *");
            double s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите время движения автомобилей:                                     *");
            double t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Через " + t +" часов расстояние между автомобилями будет равно "+ ds.DistanceOverTime(v1, v2, s, t));
            Console.ReadKey();
        }
    }
}
