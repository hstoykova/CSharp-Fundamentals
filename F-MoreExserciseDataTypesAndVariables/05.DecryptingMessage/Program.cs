int key = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
string position = null;

for (int i = 0; i < n; i++)
{
    char letter = char.Parse(Console.ReadLine());
    int letterToNum = (int)(letter) + key;
    char currentLetter = (char)letterToNum;
    position += currentLetter;
}
Console.WriteLine(position);