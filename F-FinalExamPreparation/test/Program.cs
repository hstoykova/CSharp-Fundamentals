namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Educative";
            char[] stringArray = str.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);
            Console.Write($"Actual String is : {str} \n");
            Console.Write($"Reversed String is : {reversedStr} ");
        }
    }
}