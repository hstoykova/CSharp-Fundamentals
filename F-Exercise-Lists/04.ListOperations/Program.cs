namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] segments = input.Split().ToArray();
                string command = segments[0];

                if (command == "Add")
                {
                    int number = int.Parse(segments[1]);
                    numbers.Add(number);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(segments[1]);
                    int index = int.Parse(segments[2]);

                    if (IsOutOfBounds(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, number);
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(segments[1]);

                    if (IsOutOfBounds(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(index);
                }
                else if (command == "Shift")
                {
                    if (segments[1] == "left")
                    {
                        int shifts = int.Parse(segments[2]);

                        for (int i = 0; i < shifts; i++)
                        {
                            ShiftLeft(numbers);
                        }
                    }
                    else if (segments[1] == "right")
                    {
                        int shifts = int.Parse(segments[2]);

                        for (int i = 0; i < shifts; i++)
                        {
                            ShiftRight(numbers);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static bool IsOutOfBounds(List<int> numbers, int index)
        {
            return index < 0 || index > numbers.Count - 1;
        }

        static void ShiftLeft(List<int> numbers)
        {
            int first = numbers.First();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }

            numbers[numbers.Count - 1] = first;
        }

        static void ShiftRight(List<int> numbers)
        {
            int last = numbers.Last();

            for (int i = numbers.Count - 1; i > 0; i--)
            {
                numbers[i] = numbers[i - 1];
            }

            numbers[0] = last;
        }
    }
}