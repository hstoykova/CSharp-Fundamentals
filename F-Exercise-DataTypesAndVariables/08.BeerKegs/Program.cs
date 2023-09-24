int n = int.Parse(Console.ReadLine());
double volume = 0;
string largest = null;

for (int i = 0; i < n; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    double currentVolume = Math.PI * (radius * radius) * height;

    if (currentVolume > volume)
    {
        largest = model;
        volume = currentVolume;
    }
}
Console.WriteLine(largest);