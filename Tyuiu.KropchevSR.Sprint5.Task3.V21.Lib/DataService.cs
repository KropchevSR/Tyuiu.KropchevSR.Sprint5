using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KropchevSR.Sprint5.Task3.V21.Lib
{
    public class DataService : ISprint5Task3V21
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            double y = (Math.Pow(x, 2) + 1) / Math.Sqrt(4 * Math.Pow(x, 2) - 3);
            y = Math.Round(y, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path,FileMode.OpenOrCreate),Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;

        }
    }
}
