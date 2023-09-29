string[] elements = Console.ReadLine()
    .Split()
    .ToArray();

for (int i = 0; i < elements.Length / 2; i++)
{
    string oldElement = elements[i];
    elements[i] = elements[elements.Length - 1 - i];
    elements[elements.Length - 1 - i] = oldElement;
}
Console.WriteLine(string.Join(" ", elements));


// Another solution:

//string[] elements = Console.ReadLine()
//    .Split()
//    .ToArray();

//string[] reversed = new string[elements.Length];

//for (int i = 0; i < elements.Length; i++)
//{
//    reversed[elements.Length - 1 - i] = elements[i];
//}
//Console.WriteLine(string.Join(" ", reversed));
