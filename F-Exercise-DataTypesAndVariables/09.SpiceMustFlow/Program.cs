int dailyYield = int.Parse(Console.ReadLine());
int workersConsume = 26;
int collectedYield = 0;
int days = 0;

while (dailyYield >= 100)
{
    collectedYield += dailyYield;
    collectedYield -= workersConsume;
    dailyYield -= 10;
    days++;
}

collectedYield -= workersConsume;

if (collectedYield < 0)
{
    collectedYield = 0;
}

Console.WriteLine(days);
Console.WriteLine(collectedYield);