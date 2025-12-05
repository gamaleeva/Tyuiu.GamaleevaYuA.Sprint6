using Tyuiu.GamaleevaYuA.Sprint6.Task2.V17.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint6.Task2.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double[] wait = [4.67, 0.43, -8.26, -9.87, -3.98, 1, 0.02, -1.87, 3.74, 16.43, 24.67];
            int start = -5;
            int stop = 5;
            double[] res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
