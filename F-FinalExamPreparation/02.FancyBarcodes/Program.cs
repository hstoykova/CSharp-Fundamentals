/*

3
@#FreshFisH@#
@###Brea0D@###
@##Che4s6E@##

6
@###Val1d1teM@###
@#ValidIteM@#
##InvaliDiteM##
@InvalidIteM@
@#Invalid_IteM@#
@#ValiditeM@#

*/

using System.Text;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"^@#+(?<barcode>[A-Z][A-Za-z\d]{4,}[A-Z])@#+$";
            string digitRe = @"\d";

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, regex);
                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                string barcode = match.Groups["barcode"].Value;
                MatchCollection digits = Regex.Matches(barcode, digitRe);
                StringBuilder sb = new StringBuilder();
                if (digits.Count == 0)
                {
                    sb.Append("00");
                }
                digits.Select(d => d.Value).ToList().ForEach(d => sb.Append(d));

                Console.WriteLine($"Product group: {sb}");
            }

        }
    }
}