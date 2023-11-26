/*
#Bread#19/03/21#4000#|Invalid|03/03.20||Apples|08/10/20|200||Carrots|06/08/20|500||Not right|6.8.20|5|

 */

using System.Text;
using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    class Item
    {
        public Item(string name, string expirationDate, int calories)
        {
            Name = name;
            ExpirationDate = expirationDate;
            Calories = calories;
        }

        public string Name { get; set; }
        public string ExpirationDate { get; set; }
        public int Calories { get; set; }

        public override string ToString()
        {
            return $"Item: {Name}, Best before: {ExpirationDate}, Nutrition: {Calories}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(\||\#)(?<ItemName>[a-zA-Z ]+)(\1)(?<ExpirationDate>([0-9]{2})/([0-9]{2})/([0-9]{2}))(\1)(?<Calories>\d+)(\1)";

            string input = Console.ReadLine();

            List<Item> items = new List<Item>();

            MatchCollection matches = Regex.Matches(input, regex);

            foreach (Match match in matches)
            {
                string itemName = match.Groups["ItemName"].Value;
                string expirationDate = match.Groups["ExpirationDate"].Value;
                int calories = int.Parse(match.Groups["Calories"].Value);
                items.Add(new Item(itemName, expirationDate, calories));
                //Console.WriteLine($"Item: {itemName}, Best before: {expirationDate}, Nutrition: {calories}");
            }

            int totalCalories = items.Select(i => i.Calories).Sum() / 2000;

            Console.WriteLine($"You have food to last you for: {totalCalories} days!"); // maybe need to parse it to int

            items.ForEach(Console.WriteLine);
        }
    }
}