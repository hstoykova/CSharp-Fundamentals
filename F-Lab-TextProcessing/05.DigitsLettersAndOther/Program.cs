/*
Agd#53Dfg^&4F53
 */

namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(new string (input.Where(x=>char.IsDigit(x)).ToArray()));
            Console.WriteLine(new string (input.Where(x=>char.IsLetter(x)).ToArray()));
            Console.WriteLine(new string (input.Where(x=>!char.IsLetter(x) && !char.IsDigit(x)).ToArray()));
        }
    }
}