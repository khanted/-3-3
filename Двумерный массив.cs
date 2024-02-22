using System;

public sealed class TwoDimensionArray : BaseArray, ISpecialTwoDimensionArray
{
    private int[,] numbers;

    public TwoDimensionArray(int rows, int columns, bool user)
    {
        numbers = new int[rows, columns];
        Initialize(user);
    }

    public override void Initialize(bool user)
    {
        if (user)
        {
            UserFill();
        }
        else
        {
            RandomFill();
        }
    }

    private void RandomFill()
    {
        Random random = new Random();
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers[i, j] = random.Next(-200, 200);
            }
        }
    }

    private void UserFill()
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.WriteLine($"Введите значение для элемента ({i}, {j}): ");
                numbers[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public override void Print()
    {
        Console.WriteLine("Обычный вывод двумерного массива");
        Console.WriteLine();
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write(numbers[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void DoubleArrayPrintSnake()
    {
        Console.WriteLine("Вывод двумерного массива змейкой");
        Console.WriteLine();
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            if (i % 2 == 1)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
            }

            if (i % 2 == 0)
            {
                for (int j = numbers.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write(numbers[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
    public override decimal Average()
    {
        decimal sum = 0;
        int count = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                sum += numbers[i, j];
                count++;
            }
        }
        return count == 0 ? 0 : sum / count;
    }
}
