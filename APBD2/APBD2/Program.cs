﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");


static double Func1(int[] numbers)
{
    int sum2 = 0;
    foreach (var number in numbers)
    {
        sum2 += number;
    }

    return (double) sum2 / numbers.Length;
}

static double Func2(int[] numbers)
{
    int max = 0;
    foreach (var number in numbers)
    {
        if (number > max)
        {
            max = number;
        }
    }

    return max;
}
