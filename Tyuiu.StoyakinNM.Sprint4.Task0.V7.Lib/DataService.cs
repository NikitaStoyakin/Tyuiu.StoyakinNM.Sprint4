using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.StoyakinNM.Sprint4.Task0.V7.Lib
{
    public class DataService : ISprint4Task0V7
    {
        public int GetMultOddArrEl(int[] array)
        {
            int p = 1;
            
            foreach (int i in array)
            {
                if (i % 2 == 1 )
                { 
                    p *= i;
                    
                }
            }
            return p;
        }
        
    }
}
