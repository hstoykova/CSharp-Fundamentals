using System.Collections.Generic;
using System.ComponentModel;

namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadIntList();
            string command;

            while ((command=Console.ReadLine()) != "end")
            {
                string[] newCommand = command.Split().ToArray();

                //string firstCommand = newCommand[0];

                if (newCommand[0] == "Contains")
                {
                    if (newCommand[1] == numbers.ToString())
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (newCommand[0] == "PrintEven" && numbers[i] % 2 == 0)
                        {
                            Console.WriteLine(string.Join(" ", numbers));
                        }
                    if (newCommand[0] == "PrintOdd" && numbers[i] % 2 == 1)
                    {
                        Console.WriteLine(string.Join(" ", numbers));
                    }
                }
                
            }

        }
        static List<int> ReadIntList()
        {
            return Console.ReadLine()
           .Split()
           .Select(int.Parse)
           .ToList();
        }

    }
}