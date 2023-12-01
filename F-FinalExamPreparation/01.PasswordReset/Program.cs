/*
Siiceercaroetavm!:?:ahsott.:i:nstupmomceqr 
TakeOdd
Cut 15 3
Substitute :: -
Substitute | ^
Done

 */
using System.Text;

namespace _01.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command;

            while ((command = Console.ReadLine()) != "Done")
            {
                string[] arguments = command.Split(" ");
                StringBuilder sb = new StringBuilder();
                switch (arguments[0])
                {
                    

                    case "TakeOdd":
                        
                        for (int i = 1; i < input.Length; i+=2)
                        {
                            sb.Append(input[i]);
                        }

                        input = sb.ToString();
                        Console.WriteLine(input);
                        break;
                        
                    case "Cut":
                        int index = int.Parse(arguments[1]); //15
                        int length = int.Parse(arguments[2]); //3
                        input = input.Remove(index, length);
                        Console.WriteLine(input);
                        break;

                    case "Substitute":
                        string substring = arguments[1];
                        string substitute = arguments[2];
                        if (!input.Contains(substring))
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        else
                        {
                            input = input.Replace(substring, substitute);
                            Console.WriteLine(input);
                        }
                        break;
                }
            }

            Console.WriteLine($"Your password is: {input}");
        }
    }
}