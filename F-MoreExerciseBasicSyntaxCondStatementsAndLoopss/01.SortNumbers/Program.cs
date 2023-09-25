int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

//int[] n = new int[3];

//n[0] = firstNumber;
//n[1] = secondNumber;
//n[2] = thirdNumber;

//int[] sorted = n.OrderByDescending(x => x).ToArray();


List<int> numbers = new List<int> { firstNumber, secondNumber, thirdNumber };
List<int> sorted = numbers.OrderByDescending(n => n).ToList();


for (int i = 0; i < sorted.Count; i++)
{
    Console.WriteLine(sorted[i]);
}