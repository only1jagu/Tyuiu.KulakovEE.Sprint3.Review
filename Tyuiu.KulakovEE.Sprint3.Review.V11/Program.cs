using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KulakovEE.Sprint3.Review.V11.Lib;

namespace Tyuiu.KulakovEE.Sprint3.Review.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "СпринтРевью #3 | Выполнил: Кулаков Е.Е. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* СпринтРевью #3                                                          *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Кулаков Е.Е. | АСОиУб-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = cos(x) + sin(x)/ 2-2x - 4x                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+---------+----------+");
            Console.WriteLine("|    X    |   f(x)   |");
            Console.WriteLine("+---------+----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}    | {1, 5:f2}   |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+---------+---------+");
            Console.ReadKey();
        }
    }
}