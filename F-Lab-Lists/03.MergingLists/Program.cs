using System.Collections.Generic;
using System.Threading.Channels;

namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstLine = ReadIntList();
            List<int> secondLine = ReadIntList();
            List<int> finalLine = new List<int>();

            int arrayLen = Math.Max(firstLine.Count, secondLine.Count);

            for (int i = 0; i < arrayLen; i++)
            {
                if (i < firstLine.Count)
                {
                    finalLine.Add(firstLine[i]);
                }
                if (i < secondLine.Count)
                {
                    finalLine.Add(secondLine[i]);
                }
            }
            Console.WriteLine(string.Join(" ", finalLine));

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