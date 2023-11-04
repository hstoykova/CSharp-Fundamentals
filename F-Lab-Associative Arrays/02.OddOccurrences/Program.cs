/*
Java C# PHP PHP JAVA C java

3 5 5 hi pi HO Hi 5 ho 3 hi pi
 */

namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();
            
            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordToLower = word.ToLower();

                if (count.ContainsKey(wordToLower))
                {
                    count[wordToLower]++;
                }
                else
                {
                    count.Add(wordToLower, 1);
                }
            }

            foreach (var occur in count)
            {
                if (occur.Value % 2 != 0)
                {
                    Console.Write(occur.Key + " ");
                }
            }
        }
    }
}