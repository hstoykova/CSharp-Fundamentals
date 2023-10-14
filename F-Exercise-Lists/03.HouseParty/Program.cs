namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] splitCommand = Console.ReadLine().Split().ToArray();
                string name = splitCommand[0];
                bool isInTheList = names.Contains(name);

                if (splitCommand[2] == "going!")
                {
                    if (isInTheList)
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        names.Add(name);
                    }
                }
                else if (splitCommand[2] == "not")
                {
                    if (isInTheList)
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join("\n", names));
        }
    }
}