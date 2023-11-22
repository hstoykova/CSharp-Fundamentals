/*
2
STCDoghudd4=63333$D$0A53333
EHfsytsnhf?8555&I&2C9555SR

3
tt(''DGsvywgerx>6444444444%H%1B9444
GQhrr|A977777(H(TTTT
EHfsytsnhf?8555&I&2C9555SR

*/

using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{

    class Message
    {
        public string PlanetName { get; set; }
        public uint Population { get; set; }
        public string AttackType { get; set; }
        public uint SoldierCount { get; set; }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Message> messages = new List<Message>();
            int messagesCount = int.Parse(Console.ReadLine());
            string starPattern = @"[SsTtAaRr]";
            string messagePattern = @"\@(?<Planet>[A-Za-z]+)[^\@\-\!\:\>]*:(?<Population>\d+)[^\@\-\!\:\>]*\!(?<Type>A|D)\![^\@\-\!\:\>]*\->(?<Soldiers>\d+)";

            for (int i = 0; i < messagesCount; i++)
            {
                string enctyptMessage = Console.ReadLine();
                int decryptionKey = Regex.Matches(enctyptMessage, starPattern).Count();
                StringBuilder messageBuilder = new StringBuilder();

                for (int j = 0; j < enctyptMessage.Length; j++)
                {
                    messageBuilder.Append((char)(enctyptMessage[j] - decryptionKey));
                }

                string decryptedMessage = messageBuilder.ToString();
                Match match = Regex.Match(decryptedMessage, messagePattern);
                if (!Regex.IsMatch(decryptedMessage, messagePattern))
                {
                    continue;
                }

                Message message = new Message();
                message.PlanetName = match.Groups["Planet"].Value;
                message.Population = uint.Parse(match.Groups["Population"].Value);
                message.AttackType = match.Groups["Type"].Value;
                message.SoldierCount = uint.Parse(match.Groups["Soldiers"].Value);

                messages.Add(message);
            }

            var filteredMessages = messages
                .Where(m=>m.AttackType == "A")
                .OrderBy(m=>m.PlanetName)
                .ToList();

            Console.WriteLine($"Attacked planets: {filteredMessages.Count}");
            filteredMessages.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));

            filteredMessages = messages
                .Where(m=>m.AttackType == "D")
                .OrderBy(m=>m.PlanetName)
                .ToList();

            Console.WriteLine($"Destroyed planets: {filteredMessages.Count}");
            filteredMessages.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));         
        }
    }
}