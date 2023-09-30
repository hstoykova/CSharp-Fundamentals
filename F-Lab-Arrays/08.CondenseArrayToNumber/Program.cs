using static System.Runtime.CompilerServices.RuntimeHelpers;

int[] elements = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

while (elements.Length > 1)
{
    int[] condensed = new int[elements.Length - 1];
    for (int i = 0; i < condensed.Length; i++)
    {
        condensed[i] = elements[i] + elements[i + 1];
    }
    elements = condensed;
}
Console.WriteLine(elements[0]);