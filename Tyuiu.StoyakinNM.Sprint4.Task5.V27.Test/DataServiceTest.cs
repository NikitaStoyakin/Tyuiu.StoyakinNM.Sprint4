using Tyuiu.StoyakinNM.Sprint4.Task5.V27.Lib;
namespace Tyuiu.StoyakinNM.Sprint4.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] { {-1, 4, 7, 5, 6 },
                                          {3, 5, 1, 7, 4 },
                                          {7, 4, 3, 4, 6 },
                                          {4, 4, 7, 4, 4 },
                                          {4, 5, 6, 6, 7 } };

            int res = ds.Calculate(matrix);
            int wait = 1;

            Assert.AreEqual(wait, res);
        }
    }
}