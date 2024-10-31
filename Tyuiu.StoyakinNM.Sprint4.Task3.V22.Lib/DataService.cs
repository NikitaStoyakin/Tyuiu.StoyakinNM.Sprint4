using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.StoyakinNM.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;
            int maxElement = matrix[0,0];

            for (int j = 1; j < matrix.GetLength(1) ; j++)
            {
                if (matrix[0, j] > maxElement)
                {
                    maxElement = matrix[0, j];
                }
            }
            return maxElement;
        }
    }
}
