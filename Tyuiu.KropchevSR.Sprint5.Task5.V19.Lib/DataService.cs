using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KropchevSR.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            double min = 9999999999999;
            double max = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine())!=null)
                {
                    if ((Convert.ToDouble(line) < min) & (Convert.ToDouble(line) % 10 == Convert.ToDouble(line) & (Convert.ToDouble(line) % 1 == 0)))
                    {
                        min = Convert.ToDouble(line);
                    }
                    if (Convert.ToDouble(line) > max & (Convert.ToDouble(line) % 10 == Convert.ToDouble(line) & (Convert.ToDouble(line) % 1 == 0)))
                    {
                        max = Convert.ToDouble(line);
                    }
                }
                if ((min == 9999999999999) & (max == 0)) return 0;
                else return (max - min);
            }
        }
    }
}
