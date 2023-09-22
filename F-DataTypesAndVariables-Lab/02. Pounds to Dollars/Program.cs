double poundsCount = double.Parse(Console.ReadLine());

double convertedToUsd = poundsCount * 1.31;

Console.WriteLine($"{convertedToUsd:F3}");
