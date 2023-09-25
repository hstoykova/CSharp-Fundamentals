string originalString = Console.ReadLine();

string reverseString = string.Empty;
for (int i = originalString.Length - 1; i >= 0; i--)
{
    reverseString += originalString[i];
}
Console.WriteLine(reverseString);