namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split(" -> ");
                string companyName = arguments[0];
                string employeeId = arguments[1];

                if (!companyUsers.ContainsKey(companyName))
                {
                    companyUsers.Add(companyName, new List<string> {employeeId});
                }
                else
                {
                    var ids = companyUsers.GetValueOrDefault(companyName);

                    if (!ids.Contains(employeeId))
                    {
                        ids.Add(employeeId);
                    }
                }

            }
            //KeyValuePair<string, Student> studentPair in filteredStudents
            foreach (KeyValuePair<string, List<string>> pair in companyUsers)
            {
                Console.WriteLine(pair.Key);

                foreach (var id in pair.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}