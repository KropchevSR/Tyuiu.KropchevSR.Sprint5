using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KropchevSR.Sprint5.Task7.V18.Lib
{
    public class DataService : ISprint5Task7V18
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            { File.Delete(pathSaveFile); }

            string strL = "";
            using(StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine())!=null)
                {
                    for (int i = 0; i < line.Length;i++)
                    {
                        if (line[i] == 'н') { strL = strL + "нн"; }
                        else { strL = strL + Convert.ToString(line[i]); }
                    }
                    File.AppendAllText(pathSaveFile, strL + Environment.NewLine);
                    strL = "";
                }
            }
            return pathSaveFile;
        }
    }
}
