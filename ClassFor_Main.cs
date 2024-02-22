using System;


public class ClassFor_Main
{
    public static void Main(string[] args)
    {
        // Пример использования OneDimensionalArray
        Console.WriteLine("Вы хотите заполнить массив с консоли? Введите true если да, если случайными то false.");
        bool user = bool.Parse(Console.ReadLine());
        Console.WriteLine("Введите длину массива.");
        int n = int.Parse(Console.ReadLine());
        OneDimensionalArray array = new OneDimensionalArray(n, user);
        decimal average = array.Average();
        int[] morethenhundred = new int[n];
        morethenhundred = array.Morethenhundred();
        int[] sameelements = new int[n];
        Console.WriteLine("1 Массив");
        array.Print();
        Console.WriteLine();
        Console.WriteLine("среднее значение");
        Console.WriteLine(average);
        Console.WriteLine();
        Console.WriteLine("Массив с значениями меньшими 100 по модулю");
        for (int i = 0; i < morethenhundred.Length; i++)
        {
            Console.Write(morethenhundred[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Массив без повторяющихся элементов");
        array.RemoveDuplicateAndOriginal();
        array.Print();

        Console.WriteLine("Массив дней недели");
        // Пример использования WeekDaysPrinter
        IPrintable weekDaysPrinter = new WeekDaysPrinter();
        weekDaysPrinter.Print();

        // Добавьте использование TwoDimensionArray и StairDimensionalArray аналогично
        Console.WriteLine("Вы хотите заполнить массив с консоли? Введите true если да, если случайными то false.");
        bool Doubleuser = bool.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество строк массива.");
        int Doublen = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите длину строки массива.");
        int m = int.Parse(Console.ReadLine());
        TwoDimensionArray Doublearray = new TwoDimensionArray(n, m, user);
        decimal Doubleaverage = Doublearray.Average();
        Console.WriteLine();
        Doublearray.Print();
        Console.WriteLine();
        Doublearray.DoubleArrayPrintSnake();
        Console.WriteLine();
        Console.WriteLine("Среднее значение:");
        Console.WriteLine(Doubleaverage);
        Console.WriteLine();


        Console.WriteLine("Вы хотите заполнить массив с консоли? Введите true если да, если случайными то false.");
        bool StairUser = bool.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество строк массива.");
        int Stairn = int.Parse(Console.ReadLine());
        StairDimensionalArray Stairarray = new StairDimensionalArray(StairUser, Stairn);
        decimal Stairaverage = Stairarray.Average();
        decimal[] AverageMassives = Stairarray.AverageInLines();
        Console.WriteLine("Ступенчатый массив:");
        Stairarray.Print();
        Console.WriteLine();
        Console.WriteLine("Среднее значение:");
        Console.WriteLine(Stairaverage);
        Console.WriteLine("Среднее значение в каждоом:");
        for (int i = 0; i < AverageMassives.Length; i++)
        {
            Console.WriteLine(AverageMassives[i] + " ");
        }
    }
}