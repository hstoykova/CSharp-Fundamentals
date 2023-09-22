int lostGames = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

int brokenHeadset = lostGames / 2;
int brokenMouse = lostGames / 3;
int brokenKeyboard = lostGames / 6;
int brokernDisplay = lostGames / 12;

double expenses = headsetPrice * brokenHeadset + mousePrice * brokenMouse + keyboardPrice * brokenKeyboard + displayPrice * brokernDisplay;


Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
