using System.Diagnostics.CodeAnalysis;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = Add(firstNum, secondNum);
            Console.WriteLine(Subtract(sum, thirdNum));
        }
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int b, int c)
        {
            return (b - c);
        }
    }
}