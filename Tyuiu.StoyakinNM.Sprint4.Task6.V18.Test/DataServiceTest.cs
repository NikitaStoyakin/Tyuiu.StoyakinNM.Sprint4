using Tyuiu.StoyakinNM.Sprint4.Task6.V18;
using Tyuiu.StoyakinNM.Sprint4.Task6.V18.Lib;
namespace Tyuiu.StoyakinNM.Sprint4.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var animal = new string[] { "������", "�����", "������", "�����", "�������", "�����", "��������" };
            var res = ds.Calculate(animal);
            string[] wait = { "�������", "��������" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}