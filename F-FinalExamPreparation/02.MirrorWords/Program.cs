/*
@mix#tix3dj#poOl##loOp#wl@@bong&song%4very$long@thong#Part##traP##@@leveL@@Level@##car#rac##tu@pack@@ckap@#rr#sAw##wAs#r#@w1r
 */
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"(@|#)(?<FirstWord>[A-Za-z]{3,})\1\1(?<SecondWord>[A-Za-z]{3,})\1";

            List<string> pairs = new List<string>();
            MatchCollection matches = Regex.Matches(input, regex);
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
                return;
            }

            Console.WriteLine($"{matches.Count} word pairs found!");

            foreach (Match match in matches)
            {
                string firstWord = match.Groups["FirstWord"].Value;
                string secondWord = match.Groups["SecondWord"].Value;
                var secondReversed = secondWord.ToCharArray();
                Array.Reverse(secondReversed);

                if (firstWord == new String(secondReversed))
                {
                    pairs.Add($"{firstWord} <=> {secondWord}");
                }
            }

            if (pairs.Count == 0)
            {
                Console.WriteLine("No mirror words!");
                return;
            }

            Console.WriteLine("The mirror words are:");
            Console.WriteLine(string.Join(", ", pairs));
        }
    }
}