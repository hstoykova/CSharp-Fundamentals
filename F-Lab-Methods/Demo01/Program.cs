namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = int.Parse(Console.ReadLine());
            string operatorToUse = Console.ReadLine();
            double secondNum = int.Parse(Console.ReadLine());
            double result = 0;

            switch (operatorToUse)
            {
                case "/":
                    result = Divide(firstNum, secondNum);
                    break;
                case "*":
                    result = Multiply(firstNum, secondNum);
                    break;
                case "+":
                    result = Add(firstNum, secondNum);
                    break;
                case "-":
                    result = Subtract(firstNum, secondNum);
                    break;
            }
            Console.WriteLine(result);
        }

        static double Divide(double firstNum, double secondNum) 
        {
            return firstNum / secondNum;
        }
        static double Multiply(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
        static double Add(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
        static double Subtract(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }

    }
}