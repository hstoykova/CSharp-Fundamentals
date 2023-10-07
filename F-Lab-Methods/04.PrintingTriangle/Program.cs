using System.Data.Common;

int n = int.Parse(Console.ReadLine());

for (int row = 1; row <= n; row++)
{
    PrintRow(row);
}

for (int row = n-1; row >= 0; row--)
{
    PrintRow(row);
}

static void PrintRow(int row)
{
    for (int column = 1; column <= row; column++)
    {
        Console.Write(column + " ");
    }
    Console.WriteLine();
}