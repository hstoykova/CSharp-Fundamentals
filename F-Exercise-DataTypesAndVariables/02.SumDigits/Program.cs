//int number = int.Parse(Console.ReadLine());
//string numberToString = number.ToString();

string numberToString = Console.ReadLine();
int sum = 0;

for (int i = 0; i < numberToString.Length; i++)
{
    sum += int.Parse(numberToString[i].ToString());
    //i -= 1;
}
Console.WriteLine(sum);