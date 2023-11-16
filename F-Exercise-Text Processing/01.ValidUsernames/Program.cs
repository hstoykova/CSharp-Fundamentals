/*
sh, too_long_username, !lleg@l ch@rs, jeffbutt
 */

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usenamames = Console.ReadLine().Split(", ");

            foreach (string name in usenamames)
            {
                if (name.Length >= 3 && name.Length <= 16 && isValidUsername(name))
                {
                    
                        Console.WriteLine(name);
                    
                }
            }
        }

        private static bool isValidUsername(string name)
        {
            return name.All(ch => char.IsLetterOrDigit(ch) || ch == '-' || ch == '_');
        }
    }
}