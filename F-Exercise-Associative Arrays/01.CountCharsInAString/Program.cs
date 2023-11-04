namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> occurrences = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentLetter = input[i];

                if (currentLetter == ' ')
                {
                    continue;
                }

                if (!occurrences.ContainsKey(currentLetter))
                {
                    occurrences.Add(currentLetter, 0);
                }

                occurrences[currentLetter]++;
            }

            foreach (KeyValuePair<char, int> pair in occurrences)
            {
                char charcter = pair.Key;
                int count = pair.Value;
                Console.WriteLine($"{charcter} -> {count}");
            }
        }
    }
}