/*
1 4 5 19
Add 1
Remove 4
Finish

1 20 -1 10
Collapse 8
Finish

5 9 70 -56 9 9
Replace 9 10
Remove 9
Finish

 */

namespace Solution02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input;

            while ((input = Console.ReadLine()) != "Finish")
            {
                string[] parts = input.Split().ToArray();
                string command = parts[0];
                int value = int.Parse(parts[1]);

                if (command == "Add")
                {
                    sequence.Add(value);
                }
                else if (command == "Remove")
                {
                    int index = sequence.IndexOf(value);
                    if (index != -1) // can use Remove
                    {
                        sequence.RemoveAt(index);
                    }
                }
                else if (command == "Replace")
                {
                    int replacement = int.Parse(parts[2]);
                    int index = sequence.IndexOf(value);

                    if (index != -1) 
                    {
                        sequence[index] = replacement;
                    }
                }
                else if (command == "Collapse") // can be Where
                {
                    sequence = sequence.Where(x => x >= value).ToList();
                }
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}