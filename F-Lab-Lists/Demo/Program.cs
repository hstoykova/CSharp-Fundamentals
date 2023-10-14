using System.Collections.Generic;

namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadIntList();
            string command;

            while ((command = Console.ReadLine()) != "end")
            {

                string[] newCommand = command.Split().ToArray();
                string firstCommand = newCommand[0];

                int number = int.Parse(newCommand[1]);

                if (firstCommand == "Add")
                {
                    numbers.Add(number);
                }
                else if (firstCommand == "Insert")
                {
                    int index = int.Parse(newCommand[2]);
                    numbers.Insert(index, number);
                }
                else if (firstCommand == "Remove")
                {
                    numbers.Remove(number);
                }
                else if ((firstCommand == "RemoveAt")) //RemoveAt
                {
                    numbers.RemoveAt(number);
                }

                else if(newCommand[0] == "Contains")
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
                else if (newCommand[0] == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }

            }
            Console.WriteLine(string.Join(" ", numbers));

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