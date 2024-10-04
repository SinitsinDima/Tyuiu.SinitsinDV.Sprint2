﻿
using Tyuiu.SinitsinDV.Sprint2.Task0.V25.Lib;
namespace Tyuiu.SinitsinDV.Sprint2.Task0.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            int x = 205;
            int y = 159;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #1 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #2                                         *");
            Console.WriteLine("* Тема: Операции сравнения                          *");
            Console.WriteLine("* Задание #0                                        *");
            Console.WriteLine("* Вариант #25                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу из операций сравнений          *");
            Console.WriteLine("* (==, !=, <, >, <=, >=,последовательность          *");
            Console.WriteLine("* операций не должна нарушаться)                    *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            Console.WriteLine($"X: {x}");
            Console.WriteLine($"Y: {y}");


           
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }      
    }
}
