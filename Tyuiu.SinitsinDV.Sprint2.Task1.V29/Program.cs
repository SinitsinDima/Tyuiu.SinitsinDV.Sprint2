using Tyuiu.SinitsinDV.Sprint2.Task1.V29.Lib;
namespace Tyuiu.SinitsinDV.Sprint2.Task1.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            int a = 657, b = 654, c = 657, d = 657;
            res = ds.GetLogicOperations(a, b, c, d);


            Console.Title = "Спринт #1 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #2                                         *");
            Console.WriteLine("* Тема: Логические операции                         *");
            Console.WriteLine("* Задание #1                                        *");
            Console.WriteLine("* Вариант #29                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу из операций сравнений          *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*X: " + a);
            Console.WriteLine("*Y: " + b);
            Console.WriteLine("*C: " + c);
            Console.WriteLine("*D: " + d);
            
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
