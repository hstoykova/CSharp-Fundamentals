namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long firstNum = long.Parse(Console.ReadLine());
            long secondNum = long.Parse(Console.ReadLine());

            double firstFact = Factorial(firstNum);
            double secondFact = Factorial(secondNum);

            double result = firstFact/secondFact;

            Console.WriteLine($"{result:f2}");
        }
        static double Factorial(long n)
        {
            double fact = 1;

            for (long i = n; i > 0; i--)
            {
                fact *= i;
            }

            return fact;
        }
    }
}