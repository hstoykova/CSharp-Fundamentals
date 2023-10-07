using System.Threading.Channels;

string initialStr = Console.ReadLine();
int repeatedTimes = int.Parse(Console.ReadLine());

NewCreatedString(initialStr, repeatedTimes);

static string NewCreatedString(string initialStr, int repeatedTimes)
{
    string result = "";
    for (int i = 0; i < repeatedTimes; i++)
    {
        result += initialStr;
    }
    Console.WriteLine(result);
    return result;
}
