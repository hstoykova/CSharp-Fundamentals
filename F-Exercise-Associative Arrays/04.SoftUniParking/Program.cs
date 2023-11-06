/*
5
register John CS1234JS
register George JAVA123S
register Andy AB4142CD
register Jesica VR1223EE
unregister Andy

4
register Jony AA4132BB
register Jony AA4132BB
register Linda AA9999BB
unregister Jony

6
register Jacob MM1111XX
register Anthony AB1111XX
unregister Jacob
register Joshua DD1111XX
unregister Lily
register Samantha AA9999BB

 */

namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            Dictionary<string, User> users = new Dictionary<string, User>();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string command = arguments[0];
                string userName = arguments[1];

                switch (command)
                {
                    case "register":
                        string licencePlate = arguments[2];
                        User newUser = new User(userName, licencePlate);

                        if (users.ContainsKey(userName))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licencePlate}");
                        }
                        else
                        {
                            users.Add(newUser.UserName, newUser);
                            Console.WriteLine($"{newUser.UserName} registered {licencePlate} successfully");
                        }

                        break;
                    case "unregister":
                        if (users.ContainsKey(userName))
                        {
                            users.Remove(userName);
                            Console.WriteLine($"{userName} unregistered successfully"
);
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        break;
                }
            }

            foreach (KeyValuePair<string, User> userPair in users)
            {
                Console.WriteLine(userPair.Value);
            }
        }
    }

    internal class User
    {
        public User(string userName, string licencePlate)
        {
            UserName = userName;
            LicencePlate = licencePlate;
        }

        public string UserName { get; set; }
        public string LicencePlate { get; set; }
        public override string ToString()
        {
            return $"{UserName} => {LicencePlate}";
        }
    }
}