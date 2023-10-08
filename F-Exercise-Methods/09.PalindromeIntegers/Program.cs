namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numStr;

            while ((numStr = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsPalindrome(numStr).ToString().ToLower());
            }
        }

        static bool IsPalindrome(string input)
        {
            for (int i = 0; i < input.Length/2; i++)
            {
                if (input[i] != input[input.Length-1-i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}