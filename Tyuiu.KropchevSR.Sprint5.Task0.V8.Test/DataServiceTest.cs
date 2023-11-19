using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KropchevSR.Sprint5.Task0.V8.Lib;
using System.IO;

namespace Tyuiu.KropchevSR.Sprint5.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Степан\source\repos\Tyuiu.KropchevSR.Sprint5\Tyuiu.KropchevSR.Sprint5.Task0.V8\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}