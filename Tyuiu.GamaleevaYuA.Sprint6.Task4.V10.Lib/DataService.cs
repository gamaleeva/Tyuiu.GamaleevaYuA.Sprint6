using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GamaleevaYuA.Sprint6.Task4.V10.Lib
{
    public class DataService : ISprint6Task4V10

    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            int cnt = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                double f = 0;
                f = Math.Round((5*i + 2.5)/(Math.Sin(i) + 3) + 2*i + Math.Cos(i), 2);
                if (f is double.NaN || f is double.PositiveInfinity)
                {
                    f = 0;
                }
                res[cnt++] = f;
            }
            return res;
        }
    }
}
