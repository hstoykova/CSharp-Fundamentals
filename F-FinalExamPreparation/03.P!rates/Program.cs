/*
Tortuga||345000||1250
Santo Domingo||240000||630
Havana||410000||1100
Sail
Plunder=>Tortuga=>75000=>380
Prosper=>Santo Domingo=>180
End

Nassau||95000||1000
San Juan||930000||1250
Campeche||270000||690
Port Royal||320000||1000
Port Royal||100000||2000
Sail
Prosper=>Port Royal=>-200
Plunder=>Nassau=>94000=>750
Plunder=>Nassau=>1000=>150
Plunder=>Campeche=>150000=>690
End

 */

using System.Globalization;

namespace _03.P_rates
{
    class City
    {
        public City(string name, int population, int gold)
        {
            Name = name;
            Population = population;
            Gold = gold;
        }

        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string city;
            Dictionary<string, City> cities = new Dictionary<string, City>();

            while ((city = Console.ReadLine()) != "Sail")
            {
                string[] properties = city.Split("||");
                string name = properties[0];
                int population = int.Parse(properties[1]);
                int gold = int.Parse(properties[2]);

                City town = cities.GetValueOrDefault(name, new City(name, 0, 0));
                town.Population += population;
                town.Gold += gold;

                cities[name] = town;
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] elements = command.Split("=>");
                string action = elements[0];

                if (action == "Plunder")
                {
                    string town = elements[1];
                    int people = int.Parse(elements[2]);
                    int gold = int.Parse(elements[3]);

                    cities[town].Population -= people;
                    cities[town].Gold -= gold;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (cities[town].Population == 0 || cities[town].Gold == 0)
                    {
                        cities.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (action == "Prosper")
                {
                    string town = elements[1];
                    int gold = int.Parse(elements[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }

                    cities[town].Gold += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town].Gold} gold.");

                }
            }

            if (cities.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var town in cities.Values)
                {
                    Console.WriteLine($"{town.Name} -> Population: {town.Population} citizens, Gold: {town.Gold} kg");
                }
            }
        }
    }
}