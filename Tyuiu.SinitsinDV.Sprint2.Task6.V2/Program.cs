using Tyuiu.SinitsinDV.Sprint2.Task6.V2.Lib;
namespace Tyuiu.SinitsinDV.Sprint2.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #2                                         *");
            Console.WriteLine("* Тема: Получение результата из switch              *");
            Console.WriteLine("* Задание #6                                        *");
            Console.WriteLine("* Вариант #2                                        *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Написать программу, которая использует сокращенную*");
            Console.WriteLine("* форму записи оператора switch вычисляет требуемое *");
            Console.WriteLine("* значение и возвращает результат.                  *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            Console.WriteLine("Введите номер месяца: ");
            var value = Convert.ToInt32(Console.ReadLine());
            var res = ds.FindMonthSeason(value);
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Время года " + res);

        }
    }
}
