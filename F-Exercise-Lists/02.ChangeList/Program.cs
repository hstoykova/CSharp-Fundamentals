namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] splitCommand = command.Split().ToArray();

                if (splitCommand[0] == "Delete")
                {
                    int element = int.Parse(splitCommand[1]);
                    list.RemoveAll(e => e == element);
                }
                else
                {
                    int element = int.Parse(splitCommand[1]);
                    int position = int.Parse(splitCommand[2]);
                    list.Insert(position, element);
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}