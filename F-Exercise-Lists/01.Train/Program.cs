namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int capacity = int.Parse(Console.ReadLine());
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] splittedCommand = command.Split().ToArray();

                if (splittedCommand[0] == "Add")
                {
                    int passengers = int.Parse(splittedCommand[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(splittedCommand[0]);
                    int index = wagons.FindIndex(w => w + passengers <= capacity);

                    if (index != -1)
                    {
                        wagons[index] += passengers;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}