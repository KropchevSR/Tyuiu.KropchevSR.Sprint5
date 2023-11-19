using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KropchevSR.Sprint5.Task1.V8.Lib;

namespace Tyuiu.KropchevSR.Sprint5.Task1.V8
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
            Console.WriteLine("* Таск #1                                                                              *");
            Console.WriteLine("* Вариaнт #8                                                                           *");
            Console.WriteLine("* Выполнил: Кропчев Степан РОманович     | АСОиУБ-23-1                                 *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");
            int x = -5;
            int y = 5;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + x);
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");
            string res = ds.SaveToFileTextData(x,y);

            Console.WriteLine("Файл: " + res);
            Console.ReadKey();
        }
    }
}
