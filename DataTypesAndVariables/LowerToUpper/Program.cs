using System;

namespace LowerToUpper
{
   public class Program
    {
       public static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            Console.WriteLine(char.IsUpper(input) ? "upper-case" : "lower-case");
        }
    }
}
