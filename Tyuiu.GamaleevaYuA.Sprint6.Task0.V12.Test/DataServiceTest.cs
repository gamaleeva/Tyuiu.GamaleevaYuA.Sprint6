using Tyuiu.GamaleevaYuA.Sprint6.Task0.V12.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint6.Task0.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double wait = 1.741;
            int x = 3;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
