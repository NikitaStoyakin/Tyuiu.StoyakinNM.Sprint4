using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.StoyakinNM.Sprint4.Task5.V27.Lib
{
    public class DataService : ISprint4Task5V27
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;

            int count = 0;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)

                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
            }
            return count;
        }
    }
}
