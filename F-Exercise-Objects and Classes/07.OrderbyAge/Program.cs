/*
George 123456 20
Peter 78911 15
Stephen 524244 10
End

 */
using System.Data.SqlTypes;
using System.Linq;

namespace _07.OrderbyAge
{
    class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Person> people = new List<Person>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] splittedInput = input.Split();
                string pName = splittedInput[0];
                string pId = splittedInput[1];
                int pAge = int.Parse(splittedInput[2]);

                Person existing = people.Find(x => x.Id == pId);

                if (existing is not null)
                {
                    existing.Name = pName;
                    existing.Age = pAge;
                }
                else
                {
                    Person person = new Person(pName, pId, pAge);
                    people.Add(person);
                }

            }

            List<Person> ordered = people.OrderBy(p => p.Age).ToList();

            foreach (Person person in ordered)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}