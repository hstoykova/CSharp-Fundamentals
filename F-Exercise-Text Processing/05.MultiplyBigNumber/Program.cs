namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string big = Console.ReadLine();
            int small = int.Parse(Console.ReadLine());


            if (big == "0" || small == 0)
            {
                Console.WriteLine("0");
                return;
            }

            char[] digits = new char[big.Length + 1];
            int carry = 0;

            for (int i = big.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(big[i].ToString());
                int product = digit * small + carry;

                digits[i + 1] = (char)((product % 10) + '0');
                carry = product / 10;
            }

            if (carry > 0)
            {
                digits[0] = (char)(carry + '0');
            }

            Console.WriteLine(new string(digits).TrimStart('\0'));
        }
    }
}