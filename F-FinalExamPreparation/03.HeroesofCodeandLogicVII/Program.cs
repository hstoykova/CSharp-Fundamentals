/*
2
Solmyr 85 120
Kyrre 99 50
Heal - Solmyr - 10
Recharge - Solmyr - 50
TakeDamage - Kyrre - 66 - Orc
CastSpell - Kyrre - 15 - ViewEarth
End

 */

namespace _03.HeroesofCodeandLogicVII
{
    class Hero
    {
        public Hero(string name, int hitPoints, int manaPoints)
        {
            Name = name;
            HitPoints = hitPoints;
            ManaPoints = manaPoints;
        }

        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int ManaPoints { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();

            int heroesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < heroesCount; i++)
            {
                string[] hero = Console.ReadLine().Split(" ");
                string name = hero[0];
                int hitPoints = int.Parse(hero[1]);
                int manaPoints = int.Parse(hero[2]);
                heroes.Add(name, new Hero(name, hitPoints, manaPoints));
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] parts = command.Split(" - ");
                string action = parts[0];
                string heroName = parts[1];

                switch (action)
                {
                    case "CastSpell":
                        
                        int MPneeded = int.Parse(parts[2]);
                        string spellName = parts[3];

                        if (MPneeded <= heroes[heroName].ManaPoints)
                        {
                            heroes[heroName].ManaPoints -= MPneeded;
                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName].ManaPoints} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        }
                        break;
                    case "TakeDamage":
                        int damage = int.Parse(parts[2]);
                        string attacker = parts[3];
                        heroes[heroName].HitPoints -= damage;

                        if (heroes[heroName].HitPoints > 0)
                        {
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].HitPoints} HP left!");
                        }
                        else
                        {
                            heroes.Remove(heroName);
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        }
                        break;
                    case "Recharge":
                        int amount = int.Parse(parts[2]);
                        int oldManaPoints = heroes[heroName].ManaPoints;
                        heroes[heroName].ManaPoints = Math.Min(heroes[heroName].ManaPoints + amount, 200);
                        Console.WriteLine($"{heroName} recharged for {heroes[heroName].ManaPoints - oldManaPoints} MP!"); // possible mistake here
                        break;
                    case "Heal":
                        amount = int.Parse(parts[2]);
                        int oldHitPoints = heroes[heroName].HitPoints;
                        heroes[heroName].HitPoints = Math.Min(heroes[heroName].HitPoints + amount, 100);
                        Console.WriteLine($"{heroName} healed for {heroes[heroName].HitPoints - oldHitPoints} HP!"); // possible mistake here
                        break;
                }
            }

            foreach (var h in heroes.Values)
            {
                Console.WriteLine($"{h.Name}\n  HP: {h.HitPoints}\n  MP: {h.ManaPoints}");
            }
        }
    }
}