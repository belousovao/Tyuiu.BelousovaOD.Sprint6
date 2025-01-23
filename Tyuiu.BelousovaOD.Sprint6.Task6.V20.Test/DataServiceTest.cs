﻿using System.IO;
using Tyuiu.BelousovaOD.Sprint6.Task6.V20.Lib;
namespace Tyuiu.BelousovaOD.Sprint6.Task6.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\79519\source\repos\Tyuiu.BelousovaOD.Sprint6\InPutDataFileTask6V20.txt";
            string waitStr = "dKOPBC IqjpIlKAaSCBuaQUU GPeEqZo FPsrQHsImzbTBckw NgAfitECn";
            string resStr = ds.CollectTextFromFile(path);
            Assert.AreEqual(waitStr, resStr);
        }
    }
}
