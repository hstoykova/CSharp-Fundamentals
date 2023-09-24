double availableMoney = double.Parse(Console.ReadLine());
int studentsCount = int.Parse(Console.ReadLine());
double lightsaberPrice = double.Parse(Console.ReadLine());
double robePrice = double.Parse(Console.ReadLine());
double beltPrice = double.Parse(Console.ReadLine());

double lightsabersTotal = lightsaberPrice * Math.Ceiling(studentsCount * 1.1);
double robesTotal = robePrice * studentsCount;
int freeBelts = studentsCount / 6;
double beltsTotal = beltPrice * (studentsCount - freeBelts);

double finalPrice = lightsabersTotal + robesTotal + beltsTotal;

if (availableMoney >= finalPrice)
{
    Console.WriteLine($"The money is enough - it would cost {finalPrice:F2}lv.");
}
else
{
    Console.WriteLine($"John will need {finalPrice - availableMoney:F2}lv more.");
}