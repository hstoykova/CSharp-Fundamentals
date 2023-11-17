/*
Bethany Taylor, Oliver miller, sophia Johnson, SARah Wilson, John Smith, Sam       Smith
 */

using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            MatchCollection matchedNames = Regex.Matches(input, regex);

            foreach (Match name in matchedNames) 
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}