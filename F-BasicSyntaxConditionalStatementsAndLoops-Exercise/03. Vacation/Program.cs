int countOfPeople = int.Parse(Console.ReadLine());
string typeOfGroup =  Console.ReadLine();
string dayOfWeek = Console.ReadLine();
double ticketlPrice = 0;
double totalPrice = 0;


if (typeOfGroup == "Students")
{
    switch (dayOfWeek)
    {
        case "Friday":
            ticketlPrice = 8.45;
            break;
        case "Saturday":
            ticketlPrice = 9.8;
            break;
        case "Sunday":
            ticketlPrice = 10.46;
            break;
    }
    totalPrice = countOfPeople * ticketlPrice;
    if (countOfPeople >= 30)
    {
        totalPrice *= 0.85;
    }
}

if (typeOfGroup == "Business")
{
    switch (dayOfWeek)
    {
        case "Friday":
            ticketlPrice = 10.9;
            break;
        case "Saturday":
            ticketlPrice = 15.6;
            break;
        case "Sunday":
            ticketlPrice = 16;
            break;
    }
    totalPrice = countOfPeople * ticketlPrice;
    if (countOfPeople >= 100)
    {
        totalPrice = (countOfPeople - 10) * ticketlPrice;
    }
}

if (typeOfGroup == "Regular")
{
    switch (dayOfWeek)
    {
        case "Friday":
            ticketlPrice = 15;
            break;
        case "Saturday":
            ticketlPrice = 20;
            break;
        case "Sunday":
            ticketlPrice = 22.5;
            break;
    }
    totalPrice = countOfPeople * ticketlPrice;
    if (countOfPeople >= 10 && countOfPeople <= 20)
    {
        totalPrice *= 0.95;
    }
}
Console.WriteLine($"Total price: {totalPrice:F2}");