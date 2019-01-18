using System;

namespace EvenNumber
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int even = int.Parse(Console.ReadLine());

            while (even % 2 != 0)
            {
                System.Console.WriteLine("Please write an even number.");
                even = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine($"The number is: {Math.Abs(even)}");
        }
    }
}
