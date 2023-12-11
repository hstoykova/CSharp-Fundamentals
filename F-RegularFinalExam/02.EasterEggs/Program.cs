/*
Name: 02. Easter Eggs

*/
using System.Text.RegularExpressions;

namespace Solution2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"[@#]+(?<Color>[a-z]{3,})[@#]+[^\w]*/+(?<Count>\d+)/+";

            MatchCollection matches = Regex.Matches(input, regex);

            foreach (Match m in matches)
            {
                string color = m.Groups["Color"].Value;
                string count = m.Groups["Count"].Value;

                Console.WriteLine($"You found {count} {color} eggs!");
            }
        }
    }
}