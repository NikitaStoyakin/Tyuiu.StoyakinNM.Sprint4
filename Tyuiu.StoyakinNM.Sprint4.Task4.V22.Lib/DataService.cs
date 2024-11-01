using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.StoyakinNM.Sprint4.Task4.V22.Lib
{
    public class DataService : ISprint4Task4V22
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;
            

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)

                    if (matrix[i, j] % 2 == 1 )
                    {
                        matrix[i, j] = 0;
                    }
            }
            return matrix;
        }
    }
}
