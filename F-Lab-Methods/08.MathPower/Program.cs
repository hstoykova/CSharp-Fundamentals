double number = double.Parse(Console.ReadLine());
double power = double.Parse(Console.ReadLine());

double result = ReturnPow(number, power);
Console.WriteLine(result);

double ReturnPow(double number, double power)
{
    return Math.Pow(number, power);
}