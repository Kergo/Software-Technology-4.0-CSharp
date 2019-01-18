using System;

namespace MiddleCharacters
{
   public class Program
    {
       public static void Main(string[] args)
        {
            PrintMiddleChar(Console.ReadLine());
        }

        public static void PrintMiddleChar(string text)
        {
            if (text.Length % 2 == 1)
            {
                System.Console.WriteLine(text[text.Length / 2]);
            }
            else
            {
                System.Console.Write(text[text.Length / 2 -1]);
                System.Console.WriteLine(text[text.Length / 2]);
            }
        }
    }
}
