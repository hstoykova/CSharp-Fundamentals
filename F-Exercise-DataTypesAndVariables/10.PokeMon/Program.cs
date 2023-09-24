int NpokePower = int.Parse(Console.ReadLine());
int MdistansBetweenTargets = int.Parse(Console.ReadLine());
int YexhaustionFactor = int.Parse(Console.ReadLine());

int NMSubstraction = NpokePower;
int numberOfTargets = 0;

while (NMSubstraction >=  MdistansBetweenTargets)
{
    NMSubstraction -= MdistansBetweenTargets;
    numberOfTargets++;

    if (NMSubstraction == NpokePower / 2 && YexhaustionFactor != 0)
    {
        NMSubstraction = NMSubstraction / YexhaustionFactor;
    }
}
Console.WriteLine(NMSubstraction);
Console.WriteLine(numberOfTargets);