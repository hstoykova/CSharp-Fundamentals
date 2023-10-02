using System.Xml.Linq;

int sequencesPerLine = int.Parse(Console.ReadLine());
string command = Console.ReadLine();

int counter = 0;
int max = 0;
int index = -1;
int sampleIndex = 0;
int bestSampleIndex = 0;
int[] maxSequence = new int[sequencesPerLine];

while (command != "Clone them!")
{
    sampleIndex++;

    int[] sequences = command
        .ToCharArray()
        .Where(c => c != '!')
        .Select(char.ToString)
        .Select(int.Parse)
        .ToArray();

    int firstOccurence = -1;

    for (int i = 0; i < sequences.Length - 1; i++)
    {
        if (sequences[i] == 1 && sequences[i + 1] == 1)
        { 
            if (firstOccurence == -1)
            {
                firstOccurence = i;
            }

            counter++;
        }
        else
        {
            counter = 0;
        }

        if (counter > max || counter == max && firstOccurence < index)
        {
            max = counter;
            maxSequence = sequences;
            index = firstOccurence;
            bestSampleIndex = sampleIndex;
        }
    }
    
    command = Console.ReadLine();
}

Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {maxSequence.Sum()}.");
Console.WriteLine(string.Join(" ", maxSequence));

