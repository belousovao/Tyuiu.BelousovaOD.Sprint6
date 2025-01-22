using Tyuiu.BelousovaOD.Sprint6.Task0.V28.Lib;
namespace Tyuiu.BelousovaOD.Sprint6.Task0.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 169.89;
            Assert.AreEqual(res, wait);
        }
    }
}
