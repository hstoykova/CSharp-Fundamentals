namespace MovingTarget

/*
52 74 23 44 96 110
Shoot 5 10
Shoot 1 80
Strike 2 1
Add 22 3
End

1 2 3 4 5
Strike 0 1
End

 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] segments = input.Split().ToArray();
                string command = segments[0];
                int index = int.Parse(segments[1]);
                int value = int.Parse(segments[2]);

                if (command == "Shoot" && IsInBounds(targets, index))
                {
                    //Shoot the target at the index, if it exists, by reducing its value by the given power
                    targets[index] -= value;

                    if(targets[index] <= 0)
                    {
                        targets.RemoveAt(index);
                    }
                }

                if (command == "Add")
                {
                    if (IsInBounds(targets, index))
                    {
                        //Insert a target with the received value at the received index
                        targets.Insert(index, value);   
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }

                if (command == "Strike")
                {
                    int leftIndex = index - value;
                    int rightIndex = index + value;

                    if (IsInBounds(targets, leftIndex) && IsInBounds(targets, rightIndex))
                    {
                        targets.RemoveRange(leftIndex, value * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
            }

            Console.WriteLine(string.Join("|", targets));
        }

        static bool IsInBounds(List<int> targets, int index)
        {
            return index >= 0 && index < targets.Count;
        }
    }
}