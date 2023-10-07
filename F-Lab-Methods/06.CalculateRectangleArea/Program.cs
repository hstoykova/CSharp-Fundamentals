double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

double aria = GetRectangleArea(width, height);

Console.WriteLine(aria);

static double GetRectangleArea(double width,double height)
{
    return width * height;
}