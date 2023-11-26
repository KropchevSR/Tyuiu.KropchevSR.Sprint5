using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.KropchevSR.Sprint5.Task5.V19.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = @"C:\DataSprint5\InPutDataFileTask5V19.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool wait = true;
            bool res = fileInfo.Exists;
            Assert.AreEqual(res,wait);
        }
    }
}
