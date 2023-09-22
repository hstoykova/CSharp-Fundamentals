
string command = Console.ReadLine();
double money = 0;
double sumOfCoins = 0;

while (command != "Start")
{
    if (command == "0.1")
    {
        money = 0.1;
    }
    else if (command == "0.2")
    {
        money = 0.2;
    }
    else if (command == "0.5")
    {
        money = 0.5;
    }
    else if (command == "1")
    {
        money = 1;
    }
    else if (command == "2")
    {
        money = 2;
    }
    else
    {
        Console.WriteLine($"Cannot accept {command}");
    }
    sumOfCoins += money;
    money = 0;
    command = Console.ReadLine();
}
command = Console.ReadLine();

while (command != "End")
{
    double price = 0;
    if (command == "Nuts")
    {
        price = 2;
    }
    else if (command == "Water")
    {
        price = 0.7;
    }
    else if (command == "Crisps")
    {
        price = 1.5;
    }
    else if (command == "Soda")
    {
        price = 0.8;
    }
    else if (command == "Coke")
    {
        price = 1;
    }
    else
    {
        Console.WriteLine("Invalid product");
        command = Console.ReadLine();
        continue;
    }

    if (sumOfCoins >= price)
    {
        sumOfCoins -= price;
        Console.WriteLine($"Purchased {command.ToLower()}");
    }
    else
    {
        Console.WriteLine("Sorry, not enough money");
    }
    command = Console.ReadLine();

}
Console.WriteLine($"Change: {sumOfCoins:F2}");

