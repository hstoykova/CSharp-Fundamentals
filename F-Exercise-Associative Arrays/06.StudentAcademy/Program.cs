using System.Xml.Linq;

namespace _06.StudentAcademy
{
    class Student
    {
        public string Name { get; set; }
        public List<decimal> Grades { get; set; }
        public Student(string name)
        {
            Name = name;
            Grades = new List<decimal>();
        }
        public override string ToString()
        {
            return $"{Name} -> {Grades.Average():F2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            int studentsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentsCount; i++)
            {
                string studentName = Console.ReadLine();
                decimal grade = decimal.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new Student(studentName));                    
                }
                
                    students[studentName].Grades.Add(grade);
            }

            var filteredStudents = students.Where(pair => pair.Value.Grades.Average() >= 4.50m);
            
            foreach (KeyValuePair<string, Student> studentPair in filteredStudents)
            {
                Console.WriteLine(studentPair.Value);
            }

        }
    }
}