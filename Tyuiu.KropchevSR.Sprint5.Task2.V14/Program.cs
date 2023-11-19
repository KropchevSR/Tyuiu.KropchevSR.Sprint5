using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KropchevSR.Sprint5.Task2.V14.Lib;

namespace Tyuiu.KropchevSR.Sprint5.Task2.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] x = { { -3, -6, -3 }, { 6, 8, 3 }, { -6, -5, 5 } };
            Console.Title = "Спринт #5 | Выполнил: Кропчев СР | АСОиУБ-23-1";
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                            *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                                     *");
            Console.WriteLine("* Таск #2                                                                              *");
            Console.WriteLine("* Вариaнт #14                                                                          *");
            Console.WriteLine("* Выполнил: Кропчев Степан РОманович     | АСОиУБ-23-1                                 *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("x = ");
            int rows = x.GetUpperBound(0) + 1;
            int columns = x.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{x[i, j]} \t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
                    Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");
            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.ReadKey();
        }
    }
}
