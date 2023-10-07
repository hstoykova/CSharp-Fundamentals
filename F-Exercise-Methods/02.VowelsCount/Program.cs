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
                if (digits[i] == "a" || digits[i] == "e" || digits[i] == "i" ||
                    digits[i] == "o" || digits[i] == "u")
                {
                    vowelsCount++;
                }
            }
            Console.WriteLine(vowelsCount);
        }
    }
}