﻿using Tyuiu.StoyakinNM.Sprint4.Task4.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matrix = new int[5, 5] { {4, 3, 2, 4, 5, },
                                          {5, 4, 5, 6, 6, },
                                          {6, 2, 3, 6, 5, },
                                          {6, 2, 3, 6, 4, },
                                          {6, 2, 6, 6, 2, } };

        int rows = matrix.GetUpperBound(0) + 1;
        int colums = matrix.Length / rows;
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Стоякин Н.М. | ПКТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнил: Стоякин Никита Михайлович | ПКТб 24-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 6. Заменить нечетные        *");
        Console.WriteLine("* элементы массива на 0.                                                  *");
        Console.WriteLine("* 4, 3, 2, 4, 5,                                                          *");
        Console.WriteLine("* 5, 4, 5, 6, 6,                                                          *");
        Console.WriteLine("* 6, 2, 3, 6, 5,                                                          *");
        Console.WriteLine("* 6, 2, 3, 6, 4,                                                          *");
        Console.WriteLine("* 6, 2, 6, 6, 2.                                                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Массив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ;                                                              *");
        Console.WriteLine("***************************************************************************");

        int[,] res = ds.Calculate(matrix);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                Console.Write($"{res[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
        
    }
}