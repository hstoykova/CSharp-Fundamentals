/*
ice
kicegiciceeb

 */

namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string matchWord = Console.ReadLine();
            string wholeString = Console.ReadLine();

            while (wholeString.Contains(matchWord))
            {
                wholeString = wholeString.Remove(wholeString.IndexOf(matchWord), matchWord.Length);
            }

            Console.WriteLine(wholeString);

        }
    }
}