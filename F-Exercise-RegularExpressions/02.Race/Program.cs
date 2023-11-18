/*
George, Peter, Bill, Tom
G4e@55or%6g6!68e!!@
R1@!3a$y4456@
B5@i@#123ll
G@e54o$r6ge#
7P%et^#e5346r
T$o553m&6
end of race

 */

using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace _02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameRe = @"[A-Z]+";
            string distanceRe = @"\d";
            Dictionary<string, int> racers = new Dictionary<string, int>();

            Console.ReadLine().Split(", ").ToList().ForEach(n => racers.Add(n, 0));

            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                MatchCollection matchedNames = Regex.Matches(input, nameRe, RegexOptions.IgnoreCase);
                StringBuilder nameSb = new StringBuilder();

                foreach (Match m in matchedNames)
                {
                    nameSb.Append(m.Value);
                }

                string name = nameSb.ToString();

                MatchCollection matchedDistance = Regex.Matches(input, distanceRe);
                int sum = 0;

                foreach (Match d in matchedDistance)
                {
                    sum += int.Parse(d.Value);
                }

                if (racers.ContainsKey(name))
                {
                    racers[name] = racers[name] + sum;
                }  
            }

            var pairs = racers.OrderByDescending(p => p.Value).Take(3).ToArray();

            Console.WriteLine($"1st place: {pairs[0].Key}");
            Console.WriteLine($"2nd place: {pairs[1].Key}");
            Console.WriteLine($"3rd place: {pairs[2].Key}");
        }
    }
}