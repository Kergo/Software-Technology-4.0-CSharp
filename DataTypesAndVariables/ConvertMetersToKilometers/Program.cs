using System;

namespace ConvertMetersToKilometers
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            double kilometers = (double)meters / 1000;

            System.Console.WriteLine($"{kilometers:f2}");
        }
    }
}
