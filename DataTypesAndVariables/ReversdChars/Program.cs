using System;

namespace ReversdChars
{
   public class Program
    {
       public static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            //string reversed = third.ToString() + " " + second + " " + first;
            string reversed = String.Join(" ", third, second, first);
            System.Console.WriteLine(reversed);
        }
    }
}
