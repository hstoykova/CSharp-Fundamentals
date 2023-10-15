using System.Text.RegularExpressions;

namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> appended = new List<string>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                string[] range = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                appended.AddRange(range);
            }

            Console.WriteLine(string.Join(" ", appended));
        }
    }
}