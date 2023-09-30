using System;
using System.Linq;

int n = int.Parse(Console.ReadLine());
string[] wagonPassengersArr = new string[n];

int sum = 0;

for (int i = 0; i < n; i++)
{
    int wagonPassengers = int.Parse(Console.ReadLine());
    wagonPassengersArr[i] = wagonPassengers.ToString();
    sum += wagonPassengers;
}
Console.WriteLine(string.Join(" ", wagonPassengersArr));
Console.WriteLine(sum);