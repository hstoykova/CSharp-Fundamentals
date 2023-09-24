double length = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());
double heigth = double.Parse(Console.ReadLine());
double volumeOfPyramid = (length * width * heigth) / 3.0;

Console.Write($"Length: Width: Height: ");
Console.WriteLine($"Pyramid Volume: {volumeOfPyramid:f2}");