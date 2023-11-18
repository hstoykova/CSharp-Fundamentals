/*
abv>1>1>2>2asdasd
peter>2sis>1a>2akarate>4hexmaster
 */
using System.Text;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int strength = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (c == '>')
                {
                    sb.Append(c);
                    strength += int.Parse(input[i + 1].ToString());
                    
                    if (strength > 0)
                    {
                        strength = strength - 1;
                    }
                    else 
                    {
                        sb.Append(input[i + 1]);
                    }

                    i++;
                }
                else
                {
                    if (strength > 0)
                    {
                        strength = strength - 1;
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
            }

            Console.WriteLine(sb);
        }
    }
}