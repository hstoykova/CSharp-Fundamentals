/*
zzHe
ChangeAll|z|l
Insert|2|o
Move|3
Decode


 */

namespace _01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command;

            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] arguments = command.Split("|");
                string action = arguments[0];

                switch (action)
                {
                    case "Move":
                        int numberOfLetters = int.Parse(arguments[1]);
                        string substring = input.Substring(0, numberOfLetters); // possible to be numberOfLetters - 1
                        input = input.Remove(0, numberOfLetters);
                        input = input.Insert(input.Length,substring);
                        break;

                    case "Insert":
                        int index = int.Parse(arguments[1]);
                        string value = arguments[2];
                        input = input.Insert(index, value);
                        break;

                    case "ChangeAll":
                        string substr = arguments[1];
                        string replacement = arguments[2];
                        input = input.Replace(substr, replacement);
                        break;
                }
            }

            Console.WriteLine($"The decrypted message is: {input}");

        }
    }
}