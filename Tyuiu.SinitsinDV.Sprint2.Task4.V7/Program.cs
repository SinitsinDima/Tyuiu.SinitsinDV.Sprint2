using Tyuiu.SinitsinDV.Sprint2.Task4.V7.Lib;
namespace Tyuiu.SinitsinDV.Sprint2.Task4.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            DataService ds = new DataService();

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #2                                         *");
            Console.WriteLine("* Тема: Тернарный оператор                          *");
            Console.WriteLine("* Задание #4                                        *");
            Console.WriteLine("* Вариант #7                                        *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое   *");
            Console.WriteLine("* значение с использованием тернарного оператора,где*");
            Console.WriteLine("* пользователь вводит значение переменных           *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            Console.WriteLine("Введите значение X: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            double y = double.Parse(Console.ReadLine());
            double res = ds.Calculate(x, y);


            
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Значение Z: " + res);
        }
    }
}
