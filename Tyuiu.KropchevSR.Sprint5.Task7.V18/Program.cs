using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KropchevSR.Sprint5.Task7.V18.Lib;

namespace Tyuiu.KropchevSR.Sprint5.Task7.V18
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
            Console.WriteLine("* Таск #7                                                                              *");
            Console.WriteLine("* Вариaнт #18                                                                          *");
            Console.WriteLine("* Выполнил: Кропчев Степан Романович     | АСОиУБ-23-1                                 *");
            Console.WriteLine("****************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V18.txt";
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТAТ:                                                                            *");
            Console.WriteLine("*****************************************************************************************");
            string res = ds.LoadDataAndSave(path);
            Console.WriteLine("Данные находятся в здесь: " + pathSaveFile);
            Console.ReadKey();
        }
    }
}
