namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (firstList.Count > 0 && secondList.Count > 0)
            {
                int firstDeckCard = firstList.First();
                int secondDeckCard = secondList.First();

                if (firstDeckCard > secondDeckCard)
                {
                    firstList.Add(secondDeckCard);
                    firstList.Add(firstDeckCard);
                }
                else if (secondDeckCard > firstDeckCard)
                {
                    secondList.Add(firstDeckCard);
                    secondList.Add(secondDeckCard);
                }

                firstList.RemoveAt(0);
                secondList.RemoveAt(0);
            }

            if (firstList.Sum() > secondList.Sum())
            {
                Console.WriteLine($"First player wins! Sum: {firstList.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondList.Sum()}");
            }
        }
    }
}