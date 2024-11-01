using Tyuiu.StoyakinNM.Sprint4.Task6.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Стоякин Н.М. | ПКТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Класс Array                                                       *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Стоякин Никита Михайлович | ПКТб 24-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан строковый массив данных \"Собака\", \"Кошка\", \"Кролик\",         *");
        Console.WriteLine("* \"Хомяк\", \"Попугай\", \"Рыбка\", \"Черепаха\", используя класс Array,*");
        Console.WriteLine("* выведите элементы массива, длина которых больше 6 символов.             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        var animal = new string[] { "Собака", "Кошка", "Кролик", "Хомяк", "Попугай", "Рыбка", "Черепаха" };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i <= animal.Length - 1; i++)
        {
            Console.WriteLine(animal[i]);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ;                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Элементы массива длина которых больше 6 символов:");

        var longNamedAnimals = animal.Where(a => a.Length > 6).ToArray();

        foreach (var a in longNamedAnimals)
        {
            Console.WriteLine(a);
        }
        Console.ReadKey();
    }
}