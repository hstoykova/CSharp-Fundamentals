/*

4
Lakia Eason 3.90
Prince Messing 5.49
Akiko Segers 4.85
Rocco Erben 6.00

3
Mary Elizabeth 4.22
Li Xiao 5.74
Liz Smith 4.87

 */

using System.Diagnostics;

namespace _04.Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> studentsList = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split();

                Student student = new Student();
                student.FirstName = input[0];
                student.LastName = input[1];
                student.Grade = input[2];

                studentsList.Add(student);
            }

            List<Student> newList = studentsList.OrderByDescending(student => student.Grade).ToList();

            foreach (Student student in newList)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade}");
            }

        }
    }
}