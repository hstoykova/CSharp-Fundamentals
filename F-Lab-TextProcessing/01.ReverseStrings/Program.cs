/*
helLo
Softuni
bottle
end

 */

namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                char[] stringArray = input.ToCharArray();
                Array.Reverse(stringArray);
                string reversedStr = new string(stringArray);
                Console.WriteLine($"{input} = {reversedStr}");
            }
        }
    }
}