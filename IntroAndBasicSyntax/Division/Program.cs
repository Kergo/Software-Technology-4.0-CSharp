using System;

namespace Division
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 10 == 0)
            {
                System.Console.WriteLine("The number is divisible by 10");
            }
            else if (number % 7 == 0)
            {
                System.Console.WriteLine("The number is divisible by 7");
            }
            else if (number % 6 == 0)
            {
                System.Console.WriteLine("The number is divisible by 6");
            }
            else if (number % 3 == 0)
            {
                System.Console.WriteLine("The number is divisible by 3");
            }
            else if (number % 2 == 0)
            {
                System.Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                System.Console.WriteLine("Not divisible");
            }
        }
    }
}
