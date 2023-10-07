namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (type == "int")
            {
                int a = int.Parse(first);
                int b = int.Parse(second);
                int greaterInt = GetMax(a, b);

                Console.WriteLine(greaterInt);
            }

            if (type == "string")
            {
                string greaterString = GetMax(first, second);

                Console.WriteLine(greaterString);
            }


            if (type == "char")
            {
                char a = char.Parse(first);
                char b = char.Parse(second);
                char greaterChar = GetMax(a, b);

                Console.WriteLine(greaterChar);
            }
        }

        static int GetMax(int first, int second)
            {
                return first > second ? first : second;
            }

            static string GetMax(string first, string second)
            {
                return first.Equals(second) ? first : second;
            }

            static char GetMax(char first, char second)
            {
                return first == second ? first : second;
            }
    }
}