using Tyuiu.StoyakinNM.Sprint4.Task0.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Стоякин Н.М. | ПКТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнил: Стоякин Никита Михайлович | ПКТб 24-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
        Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение   *");
        Console.WriteLine("* нечетных элементов массива.  {9, 8, 7, 9, 5, 4, 3, 2, 3, 7}             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] array = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };


        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ;                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Произведение нечетных элементов массива:" + ds.GetMultOddArrEl(array));
        Console.ReadKey();
    }
}