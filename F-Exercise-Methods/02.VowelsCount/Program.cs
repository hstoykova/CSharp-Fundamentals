namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] digits = text
                .ToString()
                .ToLower()
                .ToCharArray()
                .Select(char.ToString)
                .ToArray();

            int vowelsCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (IsVowel(digits[i]))
                {
                    vowelsCount++;
                }
            }
            Console.WriteLine(vowelsCount);
        }

        static bool IsVowel(string digit)
        {
            if (digit == "a" || digit == "e" || digit == "i" ||
                    digit == "o" || digit == "u")
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }
}