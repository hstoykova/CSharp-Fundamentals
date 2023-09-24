int numberOfPeople = int.Parse(Console.ReadLine());
int capacity = int.Parse(Console.ReadLine());

int fullCourses = (int)Math.Ceiling((double)numberOfPeople / capacity);

Console.WriteLine(fullCourses);