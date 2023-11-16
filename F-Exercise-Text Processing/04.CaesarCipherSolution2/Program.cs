using System.Text;

namespace _04.CaesarCipherSolution2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().Select(c => (char)(c + 3)).ToArray();

            Console.WriteLine(string.Join("", input));
        }
    }
}