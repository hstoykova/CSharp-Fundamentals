int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++) // row
{
    int number = 1;

    for (int j = 0; j <= i; j++) // column
    {
        Console.Write($"{number} ");
        number = number * (i - j) / (j + 1);
    }

    Console.WriteLine();
}