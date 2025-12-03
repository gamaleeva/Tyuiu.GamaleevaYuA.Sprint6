using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GamaleevaYuA.Sprint6.Task1.V29.Lib
{
    public class DataService : ISprint6Task1V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            int cnt = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                double f = 0;
                if (i + 1 != 0)
                {
                    f = Math.Round(Math.Cos(i) / (i + 1) - Math.Cos(i) * 1.3 + 3 * i, 2);
                }
                res[cnt++] = f;

            }
            return res;
        }
    }
}
