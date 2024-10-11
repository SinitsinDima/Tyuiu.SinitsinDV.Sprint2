using Tyuiu.SinitsinDV.Sprint2.Task3.V1.Lib;
namespace Tyuiu.SinitsinDV.Sprint2.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #2                                         *");
            Console.WriteLine("* Вложенные операторы if - else                     *");
            Console.WriteLine("* Задание #3                                        *");
            Console.WriteLine("* Вариант #1                                        *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое   *");
            Console.WriteLine("* значение функции Y с использованием вложенных     *");
            Console.WriteLine("* оператор if-else                                  *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = double.Parse(Console.ReadLine());
            double res = ds.Calculate(x);
            
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}
