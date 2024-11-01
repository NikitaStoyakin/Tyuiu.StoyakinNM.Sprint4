using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.StoyakinNM.Sprint4.Task6.V18.Lib
{
    public class DataService : ISprint4Task6V18
    {
        public string[] Calculate(string[] array)
        {
            var animals = array.Where(array => array.Length > 6).ToArray();

            foreach (var animal in animals)
            {
                Console.WriteLine(array);
            }
            return animals;
        }
    }
}
