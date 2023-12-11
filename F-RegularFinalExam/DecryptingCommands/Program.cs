/*
ILikeSoftUni
Replace I We
Make Upper
Check SoftUni
Sum 1 4
Cut 1 4
Finish

Name: 01. Decrypting Commands
 */

namespace Solution1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command;

            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] parts = command.Split();

                switch (parts[0])
                {
                    case "Replace":
                        string currentChar = parts[1];
                        string newChar = parts[2];
                        input = input.Replace(currentChar, newChar);
                        Console.WriteLine(input);
                        break;
                    case "Cut":
                        int startIndex = int.Parse(parts[1]);
                        int endIndex = int.Parse(parts[2]);

                        if (startIndex < input.Length && endIndex < input.Length && startIndex >= 0 && endIndex >= 0)
                        {
                            input = input.Remove(startIndex, endIndex - startIndex + 1);
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        break;
                    case "Make":
                        if (parts[1] == "Upper")
                        {
                            input = input.ToUpper();
                        }
                        else
                        {
                            input = input.ToLower();
                        }
                        Console.WriteLine(input);
                        break;
                    case "Check":
                        if (input.Contains(parts[1]))
                        {
                            Console.WriteLine($"Message contains {parts[1]}");
                        }
                        else
                        {
                            Console.WriteLine($"Message doesn't contain {parts[1]}");
                        }
                        break;
                    case "Sum":
                        int start = int.Parse(parts[1]);
                        int end = int.Parse(parts[2]);
                        if (start < input.Length && end < input.Length && start >= 0 && end >= 0)
                        {
                            string substring = input.Substring(start, end - start + 1);
                            int sum = 0;

                            foreach (var c in substring)
                            {
                                sum += c;
                            }
                            Console.WriteLine(sum);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        break;
                }
            }
        }
    }
}