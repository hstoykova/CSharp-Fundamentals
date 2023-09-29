using System.Numerics;

int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    long[] twoNumbers = Console.ReadLine()
        .Split(' ')
        .Select(long.Parse)
        .ToArray();

    long sumOfDigits = 0;

    if (twoNumbers[0] > twoNumbers[1])
    {
        long currentNum = twoNumbers[0];
        while (currentNum != 0)
        {
            sumOfDigits += currentNum % 10;
            currentNum /= 10;
        }
    }
    else
    {
        long currentNum = twoNumbers[1];
        while (currentNum != 0)
        {
            sumOfDigits += currentNum % 10;
            currentNum /= 10;
        }
    }

    Console.WriteLine(Math.Abs(sumOfDigits));
}
