/*
abcdefghijklmnopqrstuvwxyz
Slice>>>2>>>6
Flip>>>Upper>>>3>>>14
Flip>>>Lower>>>5>>>7
Contains>>>def
Contains>>>deF
Generate
 
 */
namespace _01.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string input;

            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] parts = input.Split(">>>");
                string instruction = parts[0];

                switch(instruction)
                {
                    case "Contains":
                        string substring = parts[1];

                        if (activationKey.Contains(substring))
                        {
                            Console.WriteLine($"{activationKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;

                    case "Flip":
                        string command = parts[1];
                        int startIndex = int.Parse(parts[2]);
                        int endIndex = int.Parse(parts[3]);
                        string start;
                        string middle;
                        string end;

                        if (command == "Upper")
                        {
                            start = activationKey.Substring(0, startIndex);
                            middle = activationKey.Substring(startIndex, endIndex - startIndex).ToUpper();
                            end = activationKey.Substring(endIndex);
                            activationKey = start + middle + end;
                            Console.WriteLine(activationKey);
                        }
                        else
                        {
                            start = activationKey.Substring(0, startIndex);
                            middle = activationKey.Substring(startIndex, endIndex - startIndex).ToLower();
                            end = activationKey.Substring(endIndex);
                            activationKey = start + middle + end;
                            Console.WriteLine(activationKey);
                        }
                        break;

                    case "Slice":
                        startIndex = int.Parse(parts[1]);
                        endIndex = int.Parse(parts[2]);
                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(activationKey);
                        break;
                }

            }
            Console.WriteLine($"Your activation key is: {activationKey}");

        }
    }
}