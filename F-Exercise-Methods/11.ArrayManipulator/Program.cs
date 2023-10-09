namespace _11.ArrayManipulator
{
    internal class Program
    {
        /*
        1 3 5 7 9
        exchange 1
        max odd
        min even
        first 2 odd
        last 2 even
        exchange 3
        end
        */
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split(); // exchange 1

                switch (arguments[0])
                {
                    case "exchange":
                        int index = int.Parse(arguments[1]);
                        Exchange(numbers, index);
                        break;
                    case "max":
                        string maxType = arguments[1]; //type = even || odd
                        PrintMaxNumber(numbers, maxType);
                        break;
                    case "min":
                        string minType = arguments[1]; //type = even || odd
                        PrintMinNumber(numbers, minType);
                        break;
                    case "first":
                        int firstLength = int.Parse(arguments[1]); //type = even || odd
                        string firstType = arguments[2];
                        PrintFirstElements(numbers, firstLength, firstType);
                        break;
                    case "last":
                        int lastLength = int.Parse(arguments[1]); //type = even || odd
                        string lastType = arguments[2];
                        PrintLastElements(numbers, lastLength, lastType);
                        break;
                }
                
            }
            // END while

            Console.WriteLine($"([{string.Join(", ", numbers)}])");
        }

        private static void Exchange(int[] numbers, int index)
        {
            throw new NotImplementedException();
        }
        private static void PrintMaxNumber(int[] numbers, string type) //type = "even" || "odd"
        {
            throw new NotImplementedException();
        }

        private static void PrintMinNumber(int[] numbers, string type)
        {
            throw new NotImplementedException();
        }

        private static void PrintFirstElements(int[] numbers, int length, string type)
        {
            throw new NotImplementedException();
        }

        private static void PrintLastElements(int[] numbers, int length, string type)
        {
            throw new NotImplementedException();
        }
    }
}