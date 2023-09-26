using System.Reflection;

double currentBalance = double.Parse(Console.ReadLine());
double newBalance = currentBalance;
double totalSpent = 0;
string game = Console.ReadLine();
bool isBought = false;

while (game != "Game Time")
{
    double gamePrice = 0;
    if (game == "OutFall 4")
    {
        gamePrice = 39.99;
        if (newBalance < gamePrice)
        {
            Console.WriteLine("Too Expensive");
        }
        else
        {
            totalSpent += gamePrice;
            newBalance -= gamePrice;
            Console.WriteLine($"Bought {game}");
            isBought = true;
        }
    }

    else if (game == "CS: OG")
    {
        gamePrice = 15.99;
        if (newBalance < gamePrice)
        {
            Console.WriteLine("Too Expensive");
        }
        else
        {
            totalSpent += gamePrice;
            newBalance -= gamePrice;
            Console.WriteLine($"Bought {game}");
            isBought = true;
        }
    }

    else if (game == "Zplinter Zell")
    {
        gamePrice = 19.99;
        if (newBalance < gamePrice)
        {
            Console.WriteLine("Too Expensive");
        }
        else
        {
            totalSpent += gamePrice;
            newBalance -= gamePrice;
            Console.WriteLine($"Bought {game}");
            isBought = true;
        }
    }

    else if (game == "Honored 2")
    {
        gamePrice = 59.99;
        if (newBalance < gamePrice)
        {
            Console.WriteLine("Too Expensive");
        }
        else
        {
            totalSpent += gamePrice;
            newBalance -= gamePrice;
            Console.WriteLine($"Bought {game}");
            isBought = true;
        }
    }

    else if (game == "RoverWatch")
    {
        gamePrice = 29.99;
        if (newBalance < gamePrice)
        {
            Console.WriteLine("Too Expensive");
        }
        else
        {
            totalSpent += gamePrice;
            newBalance -= gamePrice;
            Console.WriteLine($"Bought {game}");
            isBought = true;
        }
    }

    else if (game == "RoverWatch Origins Edition")
    {
        gamePrice = 39.99;
        if (newBalance < gamePrice)
        {
            Console.WriteLine("Too Expensive");
        }
        else
        {
            totalSpent += gamePrice;
            newBalance -= gamePrice;
            Console.WriteLine($"Bought {game}");
            isBought = true;
        }
    }
    else
    {
        Console.WriteLine("Not Found");
    }

    if (newBalance == 0)
    {
        Console.WriteLine("Out of money!");
        isBought = false;
        break;
    }
    game = Console.ReadLine();
}

if (isBought)
{
    Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${currentBalance - totalSpent:F2}");
}
else
{
    Console.WriteLine();
}
