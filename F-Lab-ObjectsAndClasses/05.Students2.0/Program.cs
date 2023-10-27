/*
John Smith 15 Sofia
Peter Johnson 14 Plovdiv
Peter Johnson 25 Plovdiv
Linda Bridge 16 Sofia
Linda Bridge 27 Sofia
Simon Stone 12 Varna
end
Sofia

Anthony Taylor 15 Chicago
David Anderson 16 Washington
Jack Lewis 14 Chicago
David Lee 14 Chicago
Jack Lewis 26 Chicago
David Lee 18 Chicago
end
Chicago

 */

namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentInfo;
            List<Student> students = new List<Student>();

            while ((studentInfo = Console.ReadLine()) != "end")
            {
                string[] tokens = studentInfo.Split();

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];

                Student student = new Student() // create an Object "Student"
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = homeTown
                };

                // check if student already exists:
                if (IsStudentExisting(students, firstName, lastName)) // if exists
                {
                    student = GetStudent(students, firstName, lastName, age);
                }
                else // if it's not existing
                {
                    students.Add(student);
                }
            }

            string cityName = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName, int age)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                    existingStudent.Age = age;
                }
            }

            return existingStudent;
        }

    }

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
}