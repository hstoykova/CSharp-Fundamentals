namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsTopNumber(int n)
        {
            string numberToString = n.ToString();
            int sum = 0;
            int oddCount = 0;

            for (int i = 0; i < numberToString.Length; i++)
            {
                int currentNumber = int.Parse(numberToString[i].ToString());
                sum += currentNumber;

                if (currentNumber % 2 != 0)
                {
                    oddCount++;
                }
            }

            return sum % 8 == 0 && oddCount >= 1;
        }

    }
}