using Tyuiu.GamaleevaYuA.Sprint6.Task4.V10.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint6.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            double[] wait = {-15.40, -13.31, -11.36, -8.00, -2.62, 1.83, 4.49, 6.78, 10.58, 17.38, 23.76 };
            int startStep = -5;
            int stopStep = 5;
            double[] res = ds.GetMassFunction(startStep, stopStep);
            CollectionAssert.AreEqual(res, wait);

        }
    }
}
