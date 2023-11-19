using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KropchevSR.Sprint5.Task0.V8.Lib;

namespace Tyuiu.KropchevSR.Sprint5.Task0.V8
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
            Console.WriteLine("* Таск #0                                                                              *");
            Console.WriteLine("* Вариaнт #8                                                                           *");
            Console.WriteLine("* Выполнил: Кропчев Степан Романович | АСОиУБ-23-1                                     *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в               *");
            Console.WriteLine("* файл OutPutFileTask0.txt и вывести на консоль. Округлить до трёх знаков после запятой*");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");
            int x = 4;
            Console.WriteLine(x);
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл" + res);
            Console.ReadKey();
        }
    }
}

