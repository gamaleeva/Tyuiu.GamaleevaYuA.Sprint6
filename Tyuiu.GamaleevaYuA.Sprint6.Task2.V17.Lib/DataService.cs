using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GamaleevaYuA.Sprint6.Task2.V17.Lib
{
    public class DataService : ISprint6Task2V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            int cnt = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                double f = 0;
                f = Math.Round(Math.Cos(i) + 4*i/2 - Math.Sin(i) * 3* i, 2);
                if (f is double.NaN || f is double.PositiveInfinity)
                {
                    f= 0;
                }
                res[cnt++] = f;
            }
            return res;
        }
    }
}
