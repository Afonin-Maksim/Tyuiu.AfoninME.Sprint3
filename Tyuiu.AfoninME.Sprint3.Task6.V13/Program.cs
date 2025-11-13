using Tyuiu.AfoninME.Sprint3.Task6.V13.Lib;
namespace Tyuiu.AfoninME.Sprint3.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Афонин М.Е. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Афонин М.Е. | ИСТНб-25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая ищет среди целых чисел                *");
            Console.WriteLine("* принадлежащих числовому отрезку [8, 17] сумму всех делителей больше 8   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");


            int startValue = 8;
            int stopValue = 17;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма делителей больше восьми = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();


        }
    }
}