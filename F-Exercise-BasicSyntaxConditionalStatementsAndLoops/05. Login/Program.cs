string username = Console.ReadLine();
string password = Console.ReadLine();
int attempts = 0;

string reversedPassword = string.Empty;
for (int i = username.Length - 1; i >= 0; i--)
{
    reversedPassword += username[i];
}

while (attempts <= 3)
{
    if (password != reversedPassword)
    {
        Console.WriteLine("Incorrect password. Try again.");
        password = Console.ReadLine();
    }
    else if (password == reversedPassword)
    {
        Console.WriteLine($"User {username} logged in.");
        break;
    }
    attempts ++;
    if (attempts == 3 && password != reversedPassword)
    {
        Console.WriteLine($"User {username} blocked!");
        break;
    }
}

