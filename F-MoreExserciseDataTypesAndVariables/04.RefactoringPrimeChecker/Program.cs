﻿int number = int.Parse(Console.ReadLine());

for (int i = 2; i <= number; i++)
{
    bool isTrue = true;
    
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            isTrue = false;
            break;
        }
    }
    Console.WriteLine($"{i} -> {isTrue.ToString().ToLower()}");
}