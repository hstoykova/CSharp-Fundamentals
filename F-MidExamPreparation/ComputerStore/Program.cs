/*
1050
200
450
2
18.50
16.86
special

1023
15
-20
-5.50
450
20
17.66
19.30
regular

*/

using System.Diagnostics;

namespace ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double totalPriceNoTaxes = 0;
            double priceWithTaxes = 0;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "special" || input == "regular")
                {
                    break;
                }

                double price = double.Parse(input);

                if (price < 0) // or <=
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }

                totalPriceNoTaxes += price;
                priceWithTaxes = totalPriceNoTaxes * 1.2;

                
            }

            if (totalPriceNoTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

             if (input == "special")
            {
                priceWithTaxes = (totalPriceNoTaxes * 1.2) * 0.9;
                
            }
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceNoTaxes:F2}$");
                Console.WriteLine($"Taxes: {(totalPriceNoTaxes * 0.2):F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {priceWithTaxes:F2}$");
        }
    }
 }
