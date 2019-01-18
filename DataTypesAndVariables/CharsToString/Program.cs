using System;

namespace CharsToString
{
   public class Program
    {
       public static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            string output = first.ToString() + second + third;

            System.Console.WriteLine(output);
        }
    }
}
