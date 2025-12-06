using Tyuiu.GamaleevaYuA.Sprint6.Task5.V30.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint6.Task5.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedFileExists()
        {
            DataSErvice ds = new DataSErvice();
            string path = @"C:\Users\Юлия\source\repos\Tyuiu.GamaleevaYuA.Sprint6\Tyuiu.GamaleevaYuA.Sprint6.Task5.V30\bin\Debug\InPutDataFileTask5V30.txt";
            double[] wait = { 5 };
            double[] res = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(res, wait);

        }
    }
}
