namespace MemoryGame
/*
1 1 2 2 3 3 4 4 5 5
1 0
-1 0
1 0
1 0
1 0
end

a 2 4 a 2 4
0 3
0 2
0 1
0 1
end

a 2 4 a 2 4
4 0
0 2
0 1
0 1
end

 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine()
                .Split()
                .ToList();
            string input;
            int moves = 0;
            bool won = false;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] segments = input
                    .Split()
                    .ToArray();
                int firstIndex = int.Parse(segments[0]);
                int secondIndex = int.Parse(segments[1]);

                moves++;

                if (!IsInBounds(sequence, firstIndex) || !IsInBounds(sequence, secondIndex) || firstIndex == secondIndex)
                {
                    string additionalElement = $"-{moves}a";
                    List<string> elements = new() { additionalElement, additionalElement };
                    sequence.InsertRange(sequence.Count / 2, elements);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }
                else
                {
                    string firstElement = sequence[firstIndex];
                    string secondElement = sequence[secondIndex];

                    if (firstElement == secondElement)
                    {
                        //Every time the player hit two matching elements, you should remove them from the sequence
                        Console.WriteLine($"Congrats! You have found matching elements - {firstElement}!");
                        sequence.RemoveAt(Math.Max(firstIndex, secondIndex));
                        sequence.RemoveAt(Math.Min(firstIndex, secondIndex));
                    }
                    else 
                    {
                        //If the player hit two different elements
                        Console.WriteLine("Try again!");
                    }

                    if (sequence.Count == 0 && moves > 0)
                    {
                        Console.WriteLine($"You have won in {moves} turns!");
                        won = true;
                        break;
                    }
                }            
            }

            if (!won)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", sequence));
            }  
        }

        static bool IsInBounds(List<string> sequence, int index)
        {
            return index >= 0 && index < sequence.Count;
        }
    }
}