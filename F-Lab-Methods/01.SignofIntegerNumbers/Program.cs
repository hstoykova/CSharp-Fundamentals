﻿int n = int.Parse(Console.ReadLine());

MyMethod(n);

static void MyMethod(int n)
{
    if (n > 0)
    {
        Console.WriteLine($"The number {n} is positive. ");
    }
    else if (n < 0)
    {
        Console.WriteLine($"The number {n} is negative. ");
    }
    else
    {
        Console.WriteLine($"The number {n} is zero. ");
    }
}