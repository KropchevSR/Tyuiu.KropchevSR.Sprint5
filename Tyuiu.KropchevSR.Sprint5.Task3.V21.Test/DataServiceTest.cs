﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;


namespace Tyuiu.KropchevSR.Sprint5.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Степан\source\repos\Tyuiu.KropchevSR.Sprint5\Tyuiu.KropchevSR.Sprint5.Task3.V21\bin\Debug\OutPutFileTask3.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
