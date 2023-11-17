/*
13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016
 */

using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"(?<Day>\d{2})(\/|-|\.)(?<Month>[A-Z][a-z]{2})\1(?<Year>[1-9]\d{3})\b";
            MatchCollection matches = Regex.Matches(input, regex);

            foreach (Match match in matches)
            {
                var day = match.Groups["Day"].Value;
                var month = match.Groups["Month"].Value;
                var year = match.Groups["Year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}