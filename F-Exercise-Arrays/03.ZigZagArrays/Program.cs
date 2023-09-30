int n = int.Parse(Console.ReadLine());

string[] firstArr = new string[n];
string[] secondArr = new string[n];

for (int i = 0; i < n; i++)
{
    string[] numbers = Console.ReadLine()
        .Split()
        .ToArray();
    
    if (i % 2 == 0)
    {
        firstArr[i] = numbers[0];
        secondArr[i] = numbers[1];
    }
    else
    {
        firstArr[i] = numbers[1];
        secondArr[i] = numbers[0];
    }
}
Console.WriteLine(string.Join(" ", firstArr));
Console.WriteLine(string.Join(" ", secondArr));