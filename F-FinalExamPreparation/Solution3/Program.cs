/*
 Name: 03. Wild Zoo



Add: Adam-4500-ByTheCreek
Add: Maya-7600-WaterfallArea
Add: Maya-1230-WaterfallArea
Feed: Jamie-2000
EndDay


 */
namespace Solution3
{
    class Animal
    {
        public Animal(string name, int foodQuantity, string area)
        {
            Name = name;
            FoodQuantity = foodQuantity;
            Area = area;
        }

        public string Name { get; set; }
        public int FoodQuantity { get; set; }
        public string Area { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Dictionary<string, Animal> animals = new Dictionary<string, Animal>();
            string input;

            while ((input = Console.ReadLine()) != "EndDay")
            {
                string[] parts = input.Split(": ");
                string[] animalParts = parts[1].Split("-");
                string name = animalParts[0];
                int foodQuantity = int.Parse(animalParts[1]);         

                if (parts[0] == "Add")
                {
                    string area = animalParts[2];
                    if (!animals.ContainsKey(name))
                    {
                        animals.Add(name, new Animal(name, foodQuantity, area));
                    }
                    else
                    {
                        animals[name].FoodQuantity += foodQuantity;
                    }
                }
                else if (parts[0] == "Feed")
                {
                    if (animals.ContainsKey(name))
                    {
                        animals[name].FoodQuantity -= foodQuantity;

                        if (animals[name].FoodQuantity <= 0)
                        {
                            animals.Remove(name);
                            Console.WriteLine($"{name} was successfully fed");
                        }
                    }
                }
            }
            Dictionary<string, int> areas = new Dictionary<string, int>();

            Console.WriteLine("Animals:");
            foreach (var a in animals.Values)
            {
                Console.WriteLine($" {a.Name} -> {a.FoodQuantity}g");
                var count = areas.GetValueOrDefault(a.Area, 0);

                areas[a.Area] = count + 1;
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach (var pair in areas)
            {
                Console.WriteLine($" {pair.Key}: {pair.Value}");
            }
        }
    }
}