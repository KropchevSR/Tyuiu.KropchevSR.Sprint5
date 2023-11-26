using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KropchevSR.Sprint5.Task7.V18.Lib;
using System.IO;

namespace Tyuiu.KropchevSR.Sprint5.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FileExist()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V18.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool wait = true;
            bool res = fileInfo.Exists;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask7V18.txt";
            string wait = "Словарнные слова с удвоенной согласнной нн";
            string res = ds.LoadDataAndSave(path);
            Assert.AreEqual(wait, res);

        }
    }
}
