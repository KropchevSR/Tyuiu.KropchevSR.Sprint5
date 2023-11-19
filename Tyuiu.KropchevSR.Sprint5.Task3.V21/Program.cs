using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KropchevSR.Sprint5.Task3.V21.Lib;

namespace Tyuiu.KropchevSR.Sprint5.Task3.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Кропчев СР | АСОиУБ-23-1";
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                            *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                                     *");
            Console.WriteLine("* Таск #3                                                                              *");
            Console.WriteLine("* Вариaнт #21                                                                          *");
            Console.WriteLine("* Выполнил: Кропчев Степан РОманович     | АСОиУБ-23-1                                 *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");
            int x = 3;
            Console.WriteLine($"x = {x}");
            Console.WriteLine();
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine(ds.SaveToFileTextData(x));
            Console.ReadKey();

        }
    }
}
