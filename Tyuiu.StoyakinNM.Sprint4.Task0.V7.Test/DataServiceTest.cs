using Tyuiu.StoyakinNM.Sprint4.Task0.V7.Lib;
namespace Tyuiu.StoyakinNM.Sprint4.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();

            int[] array = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
            int res = ds.GetMultOddArrEl(array);
            int waitArray = 178605;
            Assert.AreEqual(waitArray, res);
        }
    }
}