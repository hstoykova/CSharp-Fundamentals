﻿using System.Numerics;

namespace _02.BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}