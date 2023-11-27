/*
heVVodar!gniV
ChangeAll:|:V:|:l
Reverse:|:!gnil
InsertSpace:|:5
Reveal

Hiware?uiy
ChangeAll:|:i:|:o
Reverse:|:?uoy
Reverse:|:jd
InsertSpace:|:3
InsertSpace:|:7
Reveal

*/

using System.Globalization;
using System.Linq;
using System.Text;

namespace SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string instuctions;
            while ((instuctions = Console.ReadLine()) != "Reveal")
            {
                string[] commands = instuctions.Split(":|:");

                switch (commands[0])
                {
                    case "InsertSpace":
                        int index = int.Parse(commands[1]);
                        input = input.Insert(index, " ");
                        //Console.WriteLine(input);
                        break;

                    case "Reverse":
                        string substringStr = commands[1];
                        int substringIndex = input.IndexOf(substringStr);

                        if (substringIndex == -1)
                        {
                            Console.WriteLine("error");
                            continue;
                        }
                        input = input.Remove(substringIndex, substringStr.Length);
                        string reversedSubstr = new string(substringStr.Reverse().ToArray()); // ToString() can be ToArray()
                        input += reversedSubstr;
                        break;

                    case "ChangeAll":
                        string substring = commands[1];
                        string replacement = commands[2];
                        input = input.Replace(substring, replacement);
                        //Console.WriteLine(input);
                        break;
                }

                Console.WriteLine(input);
            }

            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}