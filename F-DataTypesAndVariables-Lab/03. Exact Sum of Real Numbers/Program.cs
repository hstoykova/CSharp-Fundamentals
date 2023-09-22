decimal number = decimal.Parse(Console.ReadLine());
decimal total = 0;

for (int i = 0; i < number; i++)
{
    decimal newNumber = decimal.Parse(Console.ReadLine());
    total += newNumber;
}
Console.WriteLine(total);