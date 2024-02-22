﻿using System;

public class StairDimensionalArray : BaseArray
{
    private int[][] numbers;
    private int N;

    public StairDimensionalArray(bool user, int n)
    {
        numbers = new int[n][];
        N = n;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = new int[0];
        }
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
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Введите длину строки");
            int m = int.Parse(Console.ReadLine());
            numbers[i] = new int[m];

            for (int j = 0; j < m; j++)
            {
                numbers[i][j] = random.Next(-200, 200);
            }
        }
    }

    private void UserFill()
    {
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Введите длину строки");
            int m = int.Parse(Console.ReadLine());
            numbers[i] = new int[m];

            for (int j = 0; j < m; j++)
            {
                numbers[i][j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public override void Print()
    {
        for (int i = 0; i < N; i++)
        {
            int len = numbers[i].Length;
            for (int j = 0; j < len; j++)
            {
                Console.Write(numbers[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    public override decimal Average()
    {
        decimal sum = 0;
        int divider = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < numbers[i].Length; j++)
            {
                sum += numbers[i][j];
            }
            divider += numbers[i].Length;
        }
        return sum / divider;
    }

    public decimal[] AverageInLines()
    {
        decimal[] AverageArr = new decimal[N];
        for (int i = 0; i < N; i++)
        {
            decimal sum = 0;
            for (int j = 0; j < numbers[i].Length; j++)
            {
                sum += numbers[i][j];
            }
            AverageArr[i] = sum / numbers[i].Length;
        }
        return AverageArr;
    }

    public int[][] MadeWithmassiveSecondIndex()
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < numbers[i].Length; j++)
            {
                if (numbers[i][j] % 2 == 0)
                {
                    int sum = i * j;
                    numbers[i][j] = sum;
                }
            }
        }
        return numbers;
    }
}

