using System;

namespace CharactersInRange
{
   public class Program
    {
       public static void Main(string[] args)
        {
            PrintCharactersInRange(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()));
        }
        public static void PrintCharactersInRange(char first, char second)
        {

            string charsInRange = "";

            if (second < first)
            {
                char switcher = first;
                first = second;
                second = switcher;
            }

            for (int i = first + 1; i < second; i++)
            {
                charsInRange += (char)i + " ";
            }

            System.Console.WriteLine(charsInRange);
        }
    }
}
