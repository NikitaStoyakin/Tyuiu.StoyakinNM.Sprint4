using Tyuiu.StoyakinNM.Sprint4.Task7.V29.Lib;
namespace Tyuiu.StoyakinNM.Sprint4.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 3;
            int m = 4;
            int[,] mtrx = new int[n, m];
            string str = "983157642891";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 28;
            Assert.AreEqual(wait, res);
        }
    }
}