int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    int lastDigit = i % 10;
    int otherDigit = i / 10;
    if (lastDigit + otherDigit == 5 || lastDigit + otherDigit == 7 || lastDigit + otherDigit == 11)
    {
        Console.WriteLine($"{i} -> True");
    }
    else 
    {
        Console.WriteLine($"{i} -> False");
    }
}