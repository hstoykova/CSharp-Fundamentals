using System;

/*
24 50 36 70
0
4
3
1
End

30 30 12 60 54 66
5
2
4
0
End

*/

namespace ShootForTheWin
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
            int shotCounter = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                int targetIndex = int.Parse(input);
                 
                if (IsInBounds(sequence, targetIndex))
                {
                    int targetValue = sequence[targetIndex];
                    sequence[targetIndex] = -1;
                    shotCounter++;

                    for (int i = 0; i < sequence.Count; i++)
                    {
                        // Skip the current input index
                        if (i == targetIndex || sequence[i] == -1)
                        {
                            continue;
                        }

                        if (sequence[i] > targetValue)
                        {
                            sequence[i] -= targetValue;
                        }
                        else
                        {
                            sequence[i] += targetValue;
                        }
                    }
                }
            }

            Console.WriteLine($"Shot targets: {shotCounter} -> {string.Join(" ", sequence)}");
        }

        static bool IsInBounds (List<int> sequence, int targetIndex)
        {
            return targetIndex >= 0 && targetIndex < sequence.Count;
        }
    }
}