/*
In the Sofia Zoo there are 311 animals in total! ::Smiley:: This includes 3 **Tigers**, 1 ::Elephant:, 12 **Monk3ys**, a **Gorilla::, 5 ::fox:es: and 21 different types of :Snak::Es::. ::Mooning:: **Shy**

 */

using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    class Emoji
    {
        public string Name { get; set; }
        public string Delimiter { get; set; }

        public ulong Coolness()
        {
            ulong sum = 0;

            foreach (var c in Name)
            {
                sum += c;
            }

            return sum;
        }

        public Emoji(string name, string delimiter)
        {
            Name = name;
            Delimiter = delimiter;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(::|\*\*)(?<Emoji>[A-Z][a-z]{2,})(\1)";
            string numReg = @"\d";
            ulong coolThresholdSum = 1;

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, numReg);

            foreach (Match match in matches)
            {
                coolThresholdSum *= ulong.Parse(match.Value);
            }

            Console.WriteLine($"Cool threshold: {coolThresholdSum}");

            List<Emoji> emojies = new List<Emoji>();

            MatchCollection emojiMatches = Regex.Matches(input, regex);

            foreach (Match match in emojiMatches)
            {
                string delimiter = match.Value.Substring(0, 2);
                string name = match.Groups["Emoji"].Value;
                emojies.Add(new Emoji(name, delimiter));
            }

            Console.WriteLine($"{emojies.Count} emojis found in the text. The cool ones are:");
            emojies.Where(e => e.Coolness() > coolThresholdSum).ToList().ForEach(e => Console.WriteLine($"{e.Delimiter}{e.Name}{e.Delimiter}"));
            
        }

    }
}