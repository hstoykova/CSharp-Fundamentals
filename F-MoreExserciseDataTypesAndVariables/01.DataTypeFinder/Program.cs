string input = Console.ReadLine();
string dataType = null;

while (input != "END")
{
    if (Int32.TryParse(input, out _))
    {
        dataType = "integer";
    }
    else if (float.TryParse(input, out _))
    {
        dataType = "floating point";
    }
    else if (char.TryParse(input, out _))
    {
        dataType = "character";
    }
    else if (bool.TryParse(input, out _))
    {
        dataType = "boolean";
    }
    else
    {
        dataType = "string"; 
    }
    Console.WriteLine($"{input} is {dataType} type");
    input = Console.ReadLine();
}
