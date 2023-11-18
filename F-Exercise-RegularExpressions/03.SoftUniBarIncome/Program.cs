/*
%George%<Croissant>|2|10.3$
%Peter%<Gum>|1|1.3$
%Maria%<Cola>|1|2.4$
end of shift

%InvalidName%<Croissant>|2|10.3$
%Peter%<Gum>1.3$
%Maria%<Cola>|1|2.4
%Valid%<Valid>valid|10|valid20$
end of shift

 */

using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string re = @"%(?<Customer>[A-Z][a-z]+)%[^\|\$%\.\d]*<(?<Product>\w+)>[^\|\$%\.\d]*\|(?<Count>\d+)\|[^\|\$%\.\d]*(?<Price>\d+\.\d+|\d+)\$";
            string input;
            decimal total = 0;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(input, re);
                if (match.Success)
                {
                    string customer = match.Groups["Customer"].Value;
                    string product = match.Groups["Product"].Value;
                    int count = int.Parse(match.Groups["Count"].Value);
                    decimal price = decimal.Parse(match.Groups["Price"].Value);

                    decimal totalPerPerson = count * price;
                    total += totalPerPerson;

                    Console.WriteLine($"{customer}: {product} - {totalPerPerson:F2}");
                }
            }

            Console.WriteLine($"Total income: {total:F2}");
        }
    }
}