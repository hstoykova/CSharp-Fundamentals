namespace Solution01

/*
10
7
5035.5
11.3
7.2
942.3
500.57
520.68
540.87
505.99
630.3
784.20
321.21
456.8
330


12
6
4430
9.8
5.5
620.3
840.2
960.1
220
340
674
365
345.5
212
412.12
258
496

 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine()) * players * days;
            double food = double.Parse(Console.ReadLine()) * players * days;
            int drinkingDay = 0;
            int eatingDay = 0;

            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());

                energy -= energyLoss;

                if (energy <= 0)
                {
                    break;
                }

                drinkingDay++;
                if (drinkingDay >= 2)
                {
                    energy += energy * 0.05;
                    water -= water * 0.3;
                    drinkingDay = 0;
                }

                eatingDay++;
                if (eatingDay >= 3)
                {
                    food -= food / players;
                    energy += energy * 0.1;
                    eatingDay = 0;
                }
            }

            if (energy <= 0)
            {
                Console.WriteLine($"You will run out of energy. You will be left with {food:F2} food and {water:F2} water.");
            }
            else
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:F2} energy!");
            }
        }
    }
}