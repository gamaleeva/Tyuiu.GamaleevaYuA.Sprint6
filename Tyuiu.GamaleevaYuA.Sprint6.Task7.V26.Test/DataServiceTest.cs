using System.Diagnostics;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace Tyuiu.GamaleevaYuA.Sprint6.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExists()
        {
            string path = @"C:\Users\Юлия\source\repos\Tyuiu.GamaleevaYuA.Sprint6\Tyuiu.GamaleevaYuA.Sprint6.Task7.V26\bin\Debug\net8.0-windows\OutPutFileTask7.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool res = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
