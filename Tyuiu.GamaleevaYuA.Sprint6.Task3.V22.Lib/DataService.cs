using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GamaleevaYuA.Sprint6.Task3.V22.Lib
{
    public class DataService : ISprint6Task3V22
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.GetUpperBound(1) + 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0)
                    {
                        if (matrix[i,j] % 2 == 0)
                        {
                            matrix[i, j] = 0;
                        }
                    }
                }
            }
            return matrix;
        }
    }
}
