using Tyuiu.StoyakinNM.Sprint4.Task7.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int rows = 3;
        int colums = 4;
        int[,] mtrx = new int[rows, colums];

        string str = "983157642891";

        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Стоякин Н.М. | ПКТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнил: Стоякин Никита Михайлович | ПКТб 24-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана строка из одноразрядных цифр \"983157642891\". Преобразуйте ее     *");
        Console.WriteLine("* в матрицу 4 на 3 и подсчитайте сумму четных чисел.                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int index = 0;

        Console.WriteLine("\n Массив:");
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < colums; j++)
            {
                Console.Write($"{str[index]} \t");
                index++;
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ;                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(rows, colums, str);

        Console.WriteLine("Cумма четных чисел = " + res);
        Console.ReadKey();
    }
}