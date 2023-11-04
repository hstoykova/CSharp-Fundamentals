/*
Gold
155
Silver
10
Copper
17
stop

 */

namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, uint> resources = new Dictionary<string, uint>();

            string resource;
            uint quantity;

            while ((resource = Console.ReadLine()) != "stop")
            {
                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);
                }

                quantity = uint.Parse(Console.ReadLine());
                resources[resource] += quantity;

            }

            foreach (KeyValuePair<string, uint> resourcesPair in resources)
            {
                Console.WriteLine($"{resourcesPair.Key} -> {resourcesPair.Value}");
            }
        }
    }
}