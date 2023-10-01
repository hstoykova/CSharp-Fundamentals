int[] numbers = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

int index = -1;

for (int i = 0; i < numbers.Length; i++)
{
    index = -1;
    int leftSum = 0;
    int rightSum = 0;

    for (int j = i - 1; j >= 0; j--)
    {
        leftSum += numbers[j];
    }

    for (int k = i + 1; k < numbers.Length; k++)
    {
        rightSum += numbers[k];
    }

    if (leftSum == rightSum)
    {
        index = i;
        break;
    }
}

if (index != -1)
{
    Console.WriteLine(index);
}
else
{
    Console.WriteLine("no");
}