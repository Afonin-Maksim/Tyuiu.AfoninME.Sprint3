using Tyuiu.AfoninME.Sprint3.Task3.V14.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Афонин М.Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #14                                                             *");
Console.WriteLine("* Выполнил: Афонин Максим Евгеньевич | ИСТНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Значение:");
string value = Convert.ToString(Console.ReadLine());

Console.WriteLine("Значение:");
char replaceable = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Значение:");
char replacement = Convert.ToChar(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.ReplaceCharInString(value, replaceable, replacement);

Console.WriteLine(res);

Console.ReadKey();