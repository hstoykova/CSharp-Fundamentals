namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int[] digits = number
                .ToString()
                .ToCharArray()
                .Select(char.ToString)
                .Select(int.Parse)
                .ToArray();

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] % 2 == 0)
                {
                    sumEven += digits[i];
                }
                else
                {
                    sumOdd += digits[i];
                }

            }

            Console.WriteLine($"{sumEven * sumOdd}");
        }
    }
}