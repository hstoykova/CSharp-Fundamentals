namespace TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int nonFullWagonIndex;

            while (waitingPeople > 0 && (nonFullWagonIndex = wagons.FindIndex(w => w < 4)) != -1)
            {
                int peopleInWagon = wagons[nonFullWagonIndex];
                int freeCapacity = 4 - peopleInWagon;
                int tooLate = Math.Min(freeCapacity, waitingPeople);
                wagons[nonFullWagonIndex] += tooLate;
                waitingPeople -= tooLate;
            }

            bool liftIsFull = wagons.FindIndex(w => w < 4) == -1;

            // If there are no more people and the lift has empty spots
            if (waitingPeople == 0 && !liftIsFull)
            {
                Console.WriteLine("The lift has empty spots!");
                //Console.WriteLine(string.Join(" ", wagons));
            }

            // If there are still people in the queue and no more available space
            else if (waitingPeople > 0 && liftIsFull)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                //Console.WriteLine(string.Join(" ", wagons));
            }

            // If the lift is full and there are no more people in the queu
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}