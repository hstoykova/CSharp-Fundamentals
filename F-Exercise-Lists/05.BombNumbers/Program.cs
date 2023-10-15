namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> special = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int bomb = special[0];
            int power = special[1];

            int bombIndex;

            while ((bombIndex = sequence.FindIndex(n => n == bomb)) != -1)
            {
                int rightmostIndex = bombIndex + power;
                int leftIndex = bombIndex - power;

                if (leftIndex < 0)
                {
                    leftIndex = 0;
                }

                if (rightmostIndex > sequence.Count - 1)
                {
                    rightmostIndex = sequence.Count - 1;
                }

                int elementsToRemove = rightmostIndex - leftIndex + 1;
                sequence.RemoveRange(leftIndex, elementsToRemove);
            }

            Console.WriteLine(sequence.Sum());
        }
    }
}