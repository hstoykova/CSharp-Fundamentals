namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            int startCharacter = Math.Min(firstChar, secondChar);
            int endCharacter = Math.Max(firstChar, secondChar);

            for (int i = ++startCharacter; i < endCharacter; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}