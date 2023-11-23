/*
1, 5, 1
1
cheap

5, 10, 12, 5, 4, 20
3
cheap

-2, 2, 1, 5, 9, 3, 2, -2, 1, -1, -3, 3
7
expensive

 */

namespace Solution03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<long> items = Console.ReadLine()
                .Split(", ")
                .Select(long.Parse)
                .ToList();
            int index = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            long positionPrice = items[index];

            List<long> leftItems = items.GetRange(0, index);
            List<long> rightItems = items.GetRange(index + 1, items.Count - index - 1);

            if (type == "cheap")
            {
                long leftSum = leftItems.Where(p => p < positionPrice).Sum();
                long rightSum = rightItems.Where(p => p < positionPrice).Sum();

                if (rightSum > leftSum)
                {
                    Console.WriteLine($"Right - {rightSum}");
                }
                else
                {
                    Console.WriteLine($"Left - {leftSum}");
                }
            }
            else if (type == "expensive")
            {
                long leftSum = leftItems.Where(p => p >= positionPrice).Sum();
                long rightSum = rightItems.Where(p => p >= positionPrice).Sum();

                if (rightSum > leftSum)
                {
                    Console.WriteLine($"Right - {rightSum}");
                }
                else
                {
                    Console.WriteLine($"Left - {leftSum}");
                }
            }
        }
    }
}