using Tyuiu.AfoninME.Sprint3.Task7.V4.Lib;
namespace Tyuiu.AfoninME.Sprint3.Task7.V4
{
    internal class Program
    {
        static void Main()
        {
            var ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Афонин М. Е. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Афонин Максим Евгеньевич | ИСТНб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = (2x + 6) / (cos(x) + x) - 3                                      *");
            Console.WriteLine("* на диапазоне [-5;5] с шагом 1.                                          *");
            Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
            Console.WriteLine("* Результаты округлить до двух знаков и внести в массив.                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int start = -5;
            int stop = 5;

            double[] values = ds.GetMassFunction(start, stop);

            Console.WriteLine("   x\t|\tF(x)");
            Console.WriteLine("-----------|-----------");

            for (int i = 0; i < values.Length; i++)
            {
                int x = start + i;
                Console.WriteLine($"{x,5}\t|\t{values[i],7}");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Программа завершена                                                     *");
            Console.WriteLine("***************************************************************************");
        }
    }
}