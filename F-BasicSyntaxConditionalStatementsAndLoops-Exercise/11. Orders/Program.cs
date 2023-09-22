int countOfOrders = int.Parse(Console.ReadLine());
double totalPrice = 0;
double totalForAllOrders = 0;

for (int i = 0; i < countOfOrders; i++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());
    totalPrice = ((days * capsulesCount) * pricePerCapsule);
    totalForAllOrders += totalPrice;
    Console.WriteLine($"The price for the coffee is: ${totalPrice:F2}");
}
Console.WriteLine($"Total: ${totalForAllOrders:F2}");
