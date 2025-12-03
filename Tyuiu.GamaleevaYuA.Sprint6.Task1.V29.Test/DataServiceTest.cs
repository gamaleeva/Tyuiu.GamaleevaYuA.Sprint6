using Tyuiu.GamaleevaYuA.Sprint6.Task1.V29.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint6.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double[] wait = [-15.44, -10.93, -7.22, -5.04, 0, -0.3, 2.57, 6.4, 10.04, 12.72, 14.68];
            int start = -5;
            int stop = 5;
            double[] res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
