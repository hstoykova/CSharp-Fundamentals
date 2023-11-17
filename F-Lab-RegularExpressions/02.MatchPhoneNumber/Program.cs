/*
+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222
 */
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"(\+359)(\s|-)(2)\2(\d{3})\2(\d{4})\b";
            string[] matches = Regex.Matches(input, regex).Select(m => m.Value).ToArray();

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}