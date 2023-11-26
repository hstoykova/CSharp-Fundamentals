/*
3
Fur Elise|Beethoven|A Minor
Moonlight Sonata|Beethoven|C# Minor
Clair de Lune|Debussy|C# Minor
Add|Sonata No.2|Chopin|B Minor
Add|Hungarian Rhapsody No.2|Liszt|C# Minor
Add|Fur Elise|Beethoven|C# Minor
Remove|Clair de Lune
ChangeKey|Moonlight Sonata|C# Major
Stop

4
Eine kleine Nachtmusik|Mozart|G Major
La Campanella|Liszt|G# Minor
The Marriage of Figaro|Mozart|G Major
Hungarian Dance No.5|Brahms|G Minor
Add|Spring|Vivaldi|E Major
Remove|The Marriage of Figaro
Remove|Turkish March
ChangeKey|Spring|C Major
Add|Nocturne|Chopin|C# Minor
Stop

 */

using System.Linq;

namespace _03.ThePianist
{
    class PianoPiece
    {
        public PianoPiece(string title, string composer, string key)
        {
            Title = title;
            Composer = composer;
            Key = key;
        }

        public string Title { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }

        public override string ToString()
        {
            return $"{Title} -> Composer: {Composer}, Key: {Key}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());

            Dictionary<string, PianoPiece> pieces = new Dictionary<string, PianoPiece>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] piece = Console.ReadLine()!.Split("|");
                string title = piece[0];
                string composer = piece[1];
                string key = piece[2];

                pieces.Add(title, new PianoPiece(title, composer, key));
            }

            string information;

            while ((information = Console.ReadLine()) != "Stop")
            {
                string[] arguments = information.Split("|");
                string command = arguments[0];

                switch (command)
                {
                    case "Add":
                        string piece = arguments[1];
                        string composer = arguments[2];
                        string key = arguments[3];

                        if (!pieces.ContainsKey(piece))
                        {
                            pieces.Add(piece, new PianoPiece(piece, composer, key));
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        break;

                    case "Remove":

                        piece = arguments[1];

                        if (pieces.ContainsKey(piece))
                        {
                            pieces.Remove(piece);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;

                    case "ChangeKey":
                        piece = arguments[1];
                        string newKey = arguments[2];

                        if (pieces.ContainsKey(piece))
                        {
                            pieces[piece].Key = newKey;
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }

                        break;
                }
            }

            pieces.Values.ToList().ForEach(Console.WriteLine);

        }
    }
}