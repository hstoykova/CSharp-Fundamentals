int number = int.Parse(Console.ReadLine());
int total = 0;
bool isSpecial = false;
for (int i = 1; i <= number; i++)
{
    int currentNumber = i;
    while (i > 0)
    {
        total += i % 10;
        i = i / 10;
    }
    isSpecial = (total == 5) || (total == 7) || (total == 11);
    Console.WriteLine("{0} -> {1}", currentNumber, isSpecial);
    total = 0;
    i = currentNumber;
}
