/*
3
cute
adorable
cute
charming
smart
clever

 */

using System.Reflection.Metadata;

namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> synonyms = new Dictionary<string, string>();

            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (!synonyms.ContainsKey(word))
                {
                    synonyms[word] = synonim;          
                }
                else
                {
                    synonyms[word] += ", " + synonim;
                }
            }

            foreach (KeyValuePair<string, string> synonimPair in synonyms)
            {
                Console.WriteLine($"{synonimPair.Key} - {synonimPair.Value}");
            }
        }
    }
}