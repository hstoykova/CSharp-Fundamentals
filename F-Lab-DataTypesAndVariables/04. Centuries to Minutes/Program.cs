int centuries = int.Parse(Console.ReadLine());

int toYears = centuries * 100;
int toDays = (int)(toYears * 365.2422);
int toHours = toDays * 24;
int toMinutes = toHours * 60;

Console.WriteLine($"{centuries} centuries = {toYears} years = {toDays} days = {toHours} hours = {toMinutes} minutes");