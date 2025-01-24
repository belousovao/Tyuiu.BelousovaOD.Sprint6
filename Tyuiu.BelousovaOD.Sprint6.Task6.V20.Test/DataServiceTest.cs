
using Tyuiu.BelousovaOD.Sprint6.Task6.V20.Lib;
namespace Tyuiu.BelousovaOD.Sprint6.Task6.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\79519\source\repos\Tyuiu.BelousovaOD.Sprint6\InPutFileTask6V20.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
