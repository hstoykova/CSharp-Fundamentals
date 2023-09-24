using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            for (int i = secondNum; i <= 10; i++)
            {
                Console.WriteLine($"{firstNum} X {i} = {firstNum * i}");
            }
            if (secondNum > 10)
            {
                Console.WriteLine($"{firstNum} X {secondNum} = {firstNum * secondNum}");
            }
        }
    }
}