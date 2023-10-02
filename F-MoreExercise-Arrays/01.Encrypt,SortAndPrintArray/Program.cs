int n = int.Parse(Console.ReadLine());
int[] newArr = new int[n];

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    int sumVowels = 0;
    int sumConsonant = 0;
    int total = 0;

    for (int j = 0; j < name.Length; j++)
    {
        char currentLetter = name[j];

        switch (currentLetter)
            {
                case 'a':
                case 'A':
                    sumVowels += currentLetter * name.Length;
                    break;
                case 'e':
                case 'E':
                    sumVowels += currentLetter * name.Length;
                    break;
                case 'i':
                case 'I':
                    sumVowels += currentLetter * name.Length;
                    break;
                case 'o':
                case 'O':
                    sumVowels += currentLetter * name.Length;
                    break;
                case 'u':
                case 'U':
                    sumVowels += currentLetter * name.Length;
                    break;
            default:
                sumConsonant += currentLetter / name.Length;
                break;
        }
        total = sumVowels + sumConsonant;

        newArr[i] = total;
    }
}

Array.Sort(newArr);

for (int i = 0; i < newArr.Length; i++)
{
    Console.WriteLine(newArr[i]);
}
