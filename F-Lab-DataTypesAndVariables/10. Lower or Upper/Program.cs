char symbol = char.Parse(Console.ReadLine());

bool isLower = char.IsLower(symbol);

if (isLower)
{
    Console.WriteLine("lower-case");
}
else
{
    Console.WriteLine("upper-case");
}