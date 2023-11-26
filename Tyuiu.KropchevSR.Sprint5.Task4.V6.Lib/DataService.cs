using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Threading.Tasks;

using System.IO;

namespace Tyuiu.KropchevSR.Sprint5.Task4.V6.Lib
{
    public class DataService : ISprint5Task4V6
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Round(((1 / Math.Cos(Convert.ToDouble(strX))) + (2.2 * Math.Pow(Convert.ToDouble(strX), 2))), 3);
            return res;
        }
    }
}
