using Tyuiu.StoyakinNM.Sprint4.Task2.V6.Lib;
namespace Tyuiu.StoyakinNM.Sprint4.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 2, 4, 4, 7, 2, 5, 4, 3, 3, 4, 3, 2, 3, 4, 5 };

            int res = ds.Calculate(array);
            int wait = 14175;

            Assert.AreEqual(wait, res);
        }
    }
}