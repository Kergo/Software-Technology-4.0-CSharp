using System;

namespace PalindromeIntegers
{
   public class Program
    {
       public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                PalindromeChecker(int.Parse(input));
                 input = Console.ReadLine();         
            }
        }

        public static void PalindromeChecker(int number)
        {
            number = Math.Abs(number);
            char[] chars = number.ToString().ToCharArray();

            if (chars.Length > 3)
            {
                    for (int i = 0; i < chars.Length / 2 -1; i++)
                {
                    if (chars[i] == chars[chars.Length - 1])
                    {
                       System.Console.WriteLine("true");
                    }
                    else
                    {
                        System.Console.WriteLine("false");
                    }
                }
            }
            else
            {
                if (chars.Length == 3)
                {
                    if (chars[0] == chars[2])
                    {
                        System.Console.WriteLine("true");
                    }
                    else
                    {
                        System.Console.WriteLine("false");
                    }
                }
                else if (chars.Length == 2)
                {
                    if (chars[0] == chars[1])
                    {
                        System.Console.WriteLine("true");
                    }
                    else
                    {
                        System.Console.WriteLine("false");
                    }
                }
                else
                {
                    System.Console.WriteLine("true");
                }
            }
        }
    }
}
