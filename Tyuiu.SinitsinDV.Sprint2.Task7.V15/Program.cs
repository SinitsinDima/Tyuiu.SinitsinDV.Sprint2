using Tyuiu.SinitsinDV.Sprint2.Task7.V15.Lib;
namespace Tyuiu.SinitsinDV.Sprint2.Task7.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #2                                         *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов      *");
            Console.WriteLine("* по спринту                                        *");
            Console.WriteLine("* Задание #7                                        *");
            Console.WriteLine("* Вариант #15                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает     *");
            Console.WriteLine("* исходные данные (вещественные значения) и вычисляе*");
            Console.WriteLine("* находится ли точка с координатами XY в заш области*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");


            Console.WriteLine("Введите ззначение X: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ззначение Y: ");
            double y = double.Parse(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка находится не в заштрихованной области");
            }
            


        }
    }
}
