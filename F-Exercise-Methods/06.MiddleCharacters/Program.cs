namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string someText = Console.ReadLine();

            Console.WriteLine(GetMiddleChars(someText));
        }

        static string GetMiddleChars(string text)
        {
            if (text.Length % 2 != 0)
            {
                return text[text.Length / 2].ToString();
            }
            else
            {
                return $"{text[text.Length / 2 - 1]}{text[text.Length / 2]}";
            }
        }
    }
}