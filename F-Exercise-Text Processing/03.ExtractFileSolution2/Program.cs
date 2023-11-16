namespace _03.ExtractFileSolution2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TOVA NE RABOTI V JUDGE, NO PO PRINCIP RABOTI
            string filePath = Console.ReadLine();

            Console.WriteLine($"File name: {Path.GetFileNameWithoutExtension(filePath)}");
            Console.WriteLine($"File extension: {Path.GetExtension(filePath).Replace(".", "")}");
        }
    }
}