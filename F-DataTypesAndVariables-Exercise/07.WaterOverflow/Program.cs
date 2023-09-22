int n = int.Parse(Console.ReadLine());
int sumOfLitters = 0;

for (int i = 0; i < n; i++)
{
    int newLitters = int.Parse(Console.ReadLine());
    //sumOfLitters += newLitters;
    int testSum = sumOfLitters + newLitters;

    if (testSum <= 255)
    {
        sumOfLitters = testSum;
    }
    else
    {
        Console.WriteLine("Insufficient capacity!");
    }
}
Console.WriteLine(sumOfLitters);